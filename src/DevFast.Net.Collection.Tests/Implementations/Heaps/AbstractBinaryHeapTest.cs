using System.Collections;
using System.Reflection;
using DevFast.Net.Collection.Abstractions.Heaps;
using DevFast.Net.Collection.Implementations.Heaps;

namespace DevFast.Net.Collection.Tests.Implementations.Heaps;

[TestFixture]
public class AbstractBinaryHeapTest
{
    [Test]
    [TestCase(-1)]
    [TestCase(int.MinValue)]
    public void Ctor_Throws_Error_For_Invalid_Arguments(int capacity)
    {
        Ae? ctorEx = Throws<TargetInvocationException>(() => For<AbstractBinaryHeap<int>>(capacity))?
                .InnerException as Ae;
        That(ctorEx, Is.Not.Null);
        That(ctorEx!.Message, Is.EqualTo("initialCapacity does not satisfy : 'value >= 0'."));
    }

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(10)]
    public void Properties_Are_Well_Defined(int capacity)
    {
        IHeapCollection<int> instance = For<AbstractBinaryHeap<int>>(capacity);
        That(instance, Is.Empty);
        That(instance.Count, Is.EqualTo(0));
        That(instance.Capacity, Is.EqualTo(capacity));
        That(instance.IsReadOnly, Is.False);
        if (capacity == 0)
        {
            That(instance.IsFull, Is.True);
        }
        else
        {
            That(instance.IsFull, Is.False);
        }
    }

    [Test]
    public void Add_N_Try_Add_Behaves_For_Empty_Heap()
    {
        IHeapCollection<int> instance = new TestAbstractBinaryHeap(0, (x, y) => x < y);
        That(instance.TryAdd(1), Is.False);
        InvalidOperationException? ex = Throws<InvalidOperationException>(() => instance.Add(1));
        That(ex, Is.Not.Null);
        That(ex!.Message.Equals("Unable to add element in the heap."), Is.True);
    }

    [Test]
    public void Add_N_Try_Add_Behaves_For_Non_Empty_Heap()
    {
        IHeapCollection<int> instance = new TestAbstractBinaryHeap(1, (x, y) => x < y);
        That(instance.IsEmpty, Is.True);
        That(instance.TryAdd(1), Is.True);
        That(instance.TryAdd(1), Is.False);
        InvalidOperationException? ex = Throws<InvalidOperationException>(() => instance.Add(1));
        That(ex, Is.Not.Null);
        That(ex!.Message, Is.EqualTo("Unable to add element in the heap."));
        instance = new TestAbstractBinaryHeap(3, (x, y) => x < y)
        {
            3
        };
        That(instance.IsFull, Is.False);
        instance.Add(2);
        That(instance.IsFull, Is.False);
        That(instance.TryAdd(1), Is.True);
        That(instance.IsFull, Is.True);
    }

    [Test]
    public void AddAll_Properly_Adds_All_Elements_And_Returns_The_Count()
    {
        int[] items = new[] { 2, 4, 0, 1, 2 };
        That(new TestAbstractBinaryHeap(0, (x, y) => x < y).AddAll(items).Equals(0), Is.True);
        That(new TestAbstractBinaryHeap(3, (x, y) => x < y).AddAll(items).Equals(3), Is.True);
        That(new TestAbstractBinaryHeap(5, (x, y) => x < y).AddAll(items).Equals(5), Is.True);
        That(new TestAbstractBinaryHeap(10, (x, y) => x < y).AddAll(items).Equals(5), Is.True);
    }

    [Test]
    public void PopAll_Properly_Maintains_Order_And_Sequence()
    {
        int[] items = new[] { 2, 4, 0, 1, 2 };
        int[] expected = new[] { 0, 1, 2, 2, 4 };
        TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
        _ = instance.AddAll(items);
        List<int> poppedItems = instance.PopAll().ToList();
        That(poppedItems.Count().Equals(5), Is.True);
        That(poppedItems, Is.EqualTo(expected));
        poppedItems = instance.PopAll().ToList();
        That(poppedItems.Count().Equals(0), Is.True);
        _ = instance.AddAll(items);
        poppedItems = instance.PopAll().ToList();
        That(poppedItems.Count().Equals(5), Is.True);
    }

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(10)]
    public void Peek_N_TryPeek_Behaves_For_Empty_Heap(int capacity)
    {
        IHeapCollection<int> instance = ForPartsOf<AbstractBinaryHeap<int>>(capacity);
        _ = Throws<InvalidOperationException>(() => instance.Peek());
        That(instance.TryPeek(out _), Is.False);
    }

    [Test]
    public void Peek_N_TryPeek_Behaves_For_Non_Empty_Heap()
    {
        IHeapCollection<int> instance = new TestAbstractBinaryHeap(1, (x, y) => x < y)
        {
            1
        };
        That(instance.Peek(), Is.EqualTo(1));
        That(instance.TryPeek(out int val) && val.Equals(1), Is.True);
    }

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(10)]
    public void Pop_N_TryPop_Behaves_For_Empty_Heap(int capacity)
    {
        IHeapCollection<int> instance = ForPartsOf<AbstractBinaryHeap<int>>(capacity);
        _ = Throws<InvalidOperationException>(() => instance.Pop());
        That(instance.TryPop(out _), Is.False);
    }

    [Test]
    public void Pop_N_TryPop_Behaves_For_Non_Empty_Heap()
    {
        IHeapCollection<int> instance = new TestAbstractBinaryHeap(5, (x, y) => x < y)
        {
            3,
            2,
            1,
            4,
            1
        };
        That(instance.Pop(), Is.EqualTo(1));
        That(instance.Pop(), Is.EqualTo(1));
        That(instance.Pop(), Is.EqualTo(2));
        That(instance.Pop(), Is.EqualTo(3));
        That(instance.Pop(), Is.EqualTo(4));
        That(instance.IsEmpty, Is.True);
        That(instance.TryPop(out _), Is.False);
    }

    [Test]
    public void Compact_Behaves()
    {
        AbstractBinaryHeap<int> instance = For<AbstractBinaryHeap<int>>(2);
        That(instance.Capacity, Is.EqualTo(2));
        instance.Compact();
        That(instance.Capacity, Is.EqualTo(0));
    }

    [Test]
    public void All_And_IEnumerable_Works_Fine_With()
    {
        TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
        That(instance.All().Count, Is.EqualTo(0));
        That(instance.ToList().Count, Is.EqualTo(0));
        int[] items = new[] { 100, -58, 0, -52, 1, 10 };
        _ = instance.AddAll(items);
        HashSet<int> internalState = new(instance.All());
        IEnumerable asEnumerable = instance;
        List<object> all = asEnumerable.Cast<object>().ToList();
        foreach (int item in items)
        {
            That(internalState.Contains(item), Is.True);
            That(all.Contains(item), Is.True);
        }
    }

    [Test]
    public void Clear_Works_Fine()
    {
        TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
        int[] items = new[] { 100, -58, 0, -52, 1, 10 };
        _ = instance.AddAll(items);
        That(instance.All().Count, Is.EqualTo(6));
        instance.Clear();
        That(instance.All().Count, Is.EqualTo(0));
    }

    [Test]
    public void Contains_Finds_Elements()
    {
        TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
        int[] items = new[] { 100, -58, 0, -52, 1, 10 };
        _ = instance.AddAll(items);
        That(instance.Contains(0), Is.True);
        That(instance.Contains(-58), Is.True);
        That(instance.Contains(167537573), Is.False);
        instance = new(10, (x, y) => x < y, EqualityComparer<int>.Default);
        _ = instance.AddAll(items);
        That(instance.Contains(0), Is.True);
        That(instance.Contains(-58), Is.True);
        That(instance.Contains(167537573), Is.False);
    }

    [Test]
    public void CopyTo_Correctly_Copied_Elements()
    {
        TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
        int[] items = new[] { 100, -58, 98754, -52, 1, 10 };
        _ = instance.AddAll(items);
        Ae? ex = Throws<Ae>(() => instance.CopyTo(Array.Empty<int>(), 0));
        That(ex, Is.Not.Null);
        That(ex!.Message, Is.EqualTo("array does not satisfy 'Length - arrayIndex >= Count'."));
        int[] data = new int[6];
        instance.CopyTo(data, 0);
        That(data.Contains(100), Is.True);
        That(data.Contains(-58), Is.True);
        That(data.Contains(98754), Is.True);
        That(data.Contains(-52), Is.True);
        That(data.Contains(1), Is.True);
        That(data.Contains(10), Is.True);
        data = new int[10];
        instance.CopyTo(data, 4);
        That(data[0], Is.EqualTo(0));
        That(data[1], Is.EqualTo(0));
        That(data[2], Is.EqualTo(0));
        That(data[3], Is.EqualTo(0));
        That(data.Contains(100), Is.True);
        That(data.Contains(-58), Is.True);
        That(data.Contains(98754), Is.True);
        That(data.Contains(-52), Is.True);
        That(data.Contains(1), Is.True);
        That(data.Contains(10), Is.True);
    }

    [Test]
    public void Remove_Is_NotSupported()
    {
        TestAbstractBinaryHeap instance = new(0, (x, y) => x < y);
        That(Throws<NotSupportedException>(() => instance.Remove(0)), Is.Not.Null);
    }

    [Test]
    public void AsSpan_Provides_Correct_Span_Size()
    {
        TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
        That(instance.AsSpan().IsEmpty, Is.True);
        int[] items = new[] { 100, -58, 98754, -52, 1, 10 };
        _ = instance.AddAll(items);
        That(instance.AsSpan().IsEmpty, Is.False);
        That(instance.AsSpan().Length, Is.EqualTo(6));
    }

    public class TestAbstractBinaryHeap : AbstractBinaryHeap<int>
    {
        private readonly Func<int, int, bool> _comparer;

        public TestAbstractBinaryHeap(int initialCapacity,
            Func<int, int, bool> comparer,
            IEqualityComparer<int>? eqComparer = null) : base(initialCapacity, eqComparer)
        {
            _comparer = comparer;
        }

        protected override bool LeftPrecedes(int left, int right)
        {
            return _comparer(left, right);
        }
    }
}
