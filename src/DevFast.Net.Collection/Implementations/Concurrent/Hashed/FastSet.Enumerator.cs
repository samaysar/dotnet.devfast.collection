//using System.Collections;

//namespace DevFast.Net.Collection.Implementations.Concurrent.Hashed;

//public sealed partial class FastSet<T>
//{
//    private sealed class Enumerator : IEnumerator<T>
//    {
//        private readonly FastSet<T> _instance;
//        private int _currentPosition;
//        private IEnumerator<T>? _currentEnumerator;

//#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
//        public Enumerator(FastSet<T> instance)
//#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
//        {
//            _instance = instance;
//            Reset();
//        }

//        public bool MoveNext()
//        {
//#pragma warning disable CS8601 // Possible null reference assignment.
//            Current = default;
//#pragma warning restore CS8601 // Possible null reference assignment.
//            if (_currentEnumerator == null)
//            {
//                return false;
//            }

//            if (!_currentEnumerator.MoveNext())
//            {
//                while (AcquireNextEnumerator())
//                {
//                    if (!_currentEnumerator.MoveNext())
//                    {
//                        continue;
//                    }

//                    Current = _currentEnumerator.Current;
//                    return true;
//                }

//#pragma warning disable CS8601 // Possible null reference assignment.
//                Current = default;
//#pragma warning restore CS8601 // Possible null reference assignment.
//                return false;
//            }

//            Current = _currentEnumerator.Current;
//            return true;
//        }

//        public void Reset()
//        {
//            _currentPosition = 0;
//            _currentEnumerator = ((IEnumerable<T>)[]).GetEnumerator();
//        }

//        public T Current { get; private set; }

//        object IEnumerator.Current => Current;

//        public void Dispose()
//        {
//            _currentEnumerator?.Dispose();
//            _currentEnumerator = null;
//        }

//        private bool AcquireNextEnumerator()
//        {
//            _currentEnumerator!.Dispose();
//            if (_instance.TryGetPartition(_currentPosition++, out HashSet<T>? d))
//            {
//                Monitor.Enter(d);
//                try
//                {
//                    _currentEnumerator = d.ToList().GetEnumerator();
//                }
//                finally
//                {
//                    Monitor.Exit(d);
//                }
//                return true;
//            }
//            else
//            {
//                _currentEnumerator = null;
//                return false;
//            }
//        }
//    }
//}