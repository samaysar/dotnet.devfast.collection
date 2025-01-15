using System.Collections;

namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

public sealed partial class FastReadOnlyDictionary<TKey, TValue>
{
    private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>
    {
        private readonly FastReadOnlyDictionary<TKey, TValue> _instance;
        private int _currentPosition;
        private IEnumerator<KeyValuePair<TKey, TValue>>? _currentEnumerator;

        public Enumerator(FastReadOnlyDictionary<TKey, TValue> instance)
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
            if (_instance.TryGetEnumerator(_currentPosition++, out IEnumerator<KeyValuePair<TKey, TValue>>? enumerator))
            {
                _currentEnumerator = enumerator;
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