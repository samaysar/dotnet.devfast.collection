using System.Collections;

namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

public sealed partial class FastDictionary<TKey, TValue>
{
    private sealed class KeyEnumerable(FastDictionary<TKey, TValue> instance) : IEnumerable<TKey>
    {
        private readonly FastDictionary<TKey, TValue> _instance = instance;

        public IEnumerator<TKey> GetEnumerator()
        {
            return new KeyEnumerator(_instance);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    private sealed class KeyEnumerator : IEnumerator<TKey>
    {
        private readonly FastDictionary<TKey, TValue> _instance;
        private int _currentPosition;
        private IEnumerator<TKey>? _currentEnumerator;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public KeyEnumerator(FastDictionary<TKey, TValue> instance)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _instance = instance;
            Reset();
        }

        public bool MoveNext()
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            Current = default;
#pragma warning restore CS8601 // Possible null reference assignment.
            if (_currentEnumerator == null)
            {
                return false;
            }

            if (!_currentEnumerator.MoveNext())
            {
                while (AcquireNextEnumerator())
                {
                    if (!_currentEnumerator.MoveNext())
                    {
                        continue;
                    }

                    Current = _currentEnumerator.Current;
                    return true;
                }

#pragma warning disable CS8601 // Possible null reference assignment.
                Current = default;
#pragma warning restore CS8601 // Possible null reference assignment.
                return false;
            }

            Current = _currentEnumerator.Current;
            return true;
        }

        public void Reset()
        {
            _currentPosition = 0;
            _currentEnumerator = ((IEnumerable<TKey>)[]).GetEnumerator();
        }

        public TKey Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _currentEnumerator?.Dispose();
            _currentEnumerator = null;
        }

        private bool AcquireNextEnumerator()
        {
            _currentEnumerator!.Dispose();
            if (_instance.TryGetPartition(_currentPosition++, out Dictionary<TKey, TValue>? d))
            {
                Monitor.Enter(d);
                try
                {
                    _currentEnumerator = new List<TKey>(d.Keys).GetEnumerator();
                }
                finally
                {
                    Monitor.Exit(d);
                }
                return true;
            }
            else
            {
                _currentEnumerator = null;
                return false;
            }
        }
    }
}
