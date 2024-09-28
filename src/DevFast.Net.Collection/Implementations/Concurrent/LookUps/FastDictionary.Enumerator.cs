using System.Collections;

namespace DevFast.Net.Collection.Implementations.Concurrent.LookUps;

public sealed partial class FastDictionary<TKey, TValue>
{
    private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>
    {
        private readonly FastDictionary<TKey, TValue> _instance;
        private int _currentPosition;
        private IEnumerator<KeyValuePair<TKey, TValue>>? _currentEnumerator;

        public Enumerator(FastDictionary<TKey, TValue> instance)
        {
            _instance = instance;
            Reset();
        }

        public bool MoveNext()
        {
            Current = default;
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

                Current = default;
                return false;
            }

            Current = _currentEnumerator.Current;
            return true;
        }

        public void Reset()
        {
            _currentPosition = 0;
            _currentEnumerator = ((IEnumerable<KeyValuePair<TKey, TValue>>)[]).GetEnumerator();
        }

        public KeyValuePair<TKey, TValue> Current { get; private set; }

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
                    _currentEnumerator = d.ToList().GetEnumerator();
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
