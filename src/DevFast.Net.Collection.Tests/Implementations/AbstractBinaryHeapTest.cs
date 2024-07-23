using System.Reflection;
using DevFast.Net.Collection.Abstractions.Heaps;
using DevFast.Net.Collection.Implementations.Heaps;

namespace DevFast.Net.Collection.Tests.Implementations;

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
        That(ctorEx!.Message, Is.EqualTo("Inside AbstractBinaryHeap, initialCapacity does not satisfy : 'value > 0'."));
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

    //[Test]
    //public void Peek_N_TryPeek_Behaves_For_Non_Empty_Heap()
    //{
    //    IHeapCollection<int> instance = new TestAbstractBinaryHeap(1, (x, y) => x < y)
    //    {
    //        1
    //    };
    //    Assert.AreEqual(instance.Peek(), 1);
    //    Assert.True(instance.TryPeek(out int val) && val.Equals(1));
    //}

    //[Test]
    //[TestCase(0)]
    //[TestCase(1)]
    //[TestCase(10)]
    //public void Pop_N_TryPop_Behaves_For_Empty_Heap(int capacity)
    //{
    //    IHeapCollection<int> instance = ForPartsOf<AbstractBinaryHeap<int>>(capacity);
    //    _ = Throws<IndexOutOfRangeException>(() => instance.Pop());
    //    Assert.False(instance.TryPop(out _));
    //}

    //[Test]
    //public void Pop_N_TryPop_Behaves_For_Non_Empty_Heap()
    //{
    //    IHeapCollection<int> instance = new TestAbstractBinaryHeap(5, (x, y) => x < y)
    //    {
    //        3,
    //        2,
    //        1,
    //        4,
    //        1
    //    };
    //    Assert.AreEqual(instance.Pop(), 1);
    //    Assert.AreEqual(instance.Pop(), 1);
    //    Assert.AreEqual(instance.Pop(), 2);
    //    Assert.AreEqual(instance.Pop(), 3);
    //    Assert.AreEqual(instance.Pop(), 4);
    //    Assert.True(instance.IsEmpty);
    //    Assert.IsFalse(instance.TryPop(out _));
    //}

    //[Test]
    //public void Compact_Behaves()
    //{
    //    AbstractBinaryHeap<int> instance = For<AbstractBinaryHeap<int>>(2);
    //    Assert.AreEqual(instance.Capacity, 2);
    //    instance.Compact();
    //    Assert.AreEqual(instance.Capacity, 0);
    //}

    //[Test]
    //public void GetFirstUnsafe_Throws_Error_When_Capacity_Is_Zero()
    //{
    //    AbstractBinaryHeap<int> instance = For<AbstractBinaryHeap<int>>(0);
    //    _ = Assert.Throws<IndexOutOfRangeException>(() => instance.GetFirstUnsafe());
    //}

    //[Test]
    //public void GetFirstUnsafe_Blindly_Returns_Whatever_At_0Th_Index_Irrespective_Of_Count()
    //{
    //    TestAbstractBinaryHeap instance = new(5, (x, y) => x < y);
    //    Assert.IsTrue(instance.GetFirstUnsafe().Equals(0));
    //    instance.Add(0);
    //    Assert.IsTrue(instance.GetFirstUnsafe().Equals(0));
    //    instance.Add(-1);
    //    Assert.IsTrue(instance.GetFirstUnsafe().Equals(-1));
    //}

    //[Test]
    //public void InternalStateAsEnumerable_Exposes_Internal_Buffer()
    //{
    //    TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
    //    Assert.True(instance.InternalStateAsEnumerable().ToList().Count.Equals(0));
    //    int[] items = new[] { 100, -58, 0, -52, 1, 10 };
    //    _ = instance.AddAll(items);
    //    HashSet<int> internalState = new(instance.InternalStateAsEnumerable());
    //    foreach (int item in items)
    //    {
    //        Assert.IsTrue(internalState.Contains(item));
    //    }
    //}

    //[Test]
    //public void IEnumerable_Works_Fine_With_All()
    //{
    //    TestAbstractBinaryHeap instance = new(10, (x, y) => x < y);
    //    Assert.True(instance.ToList().Count.Equals(0));
    //    int[] items = new[] { 100, -58, 0, -52, 1, 10 };
    //    _ = instance.AddAll(items);
    //    HashSet<int> internalState = new(instance.All());
    //    IEnumerable<T> asEnumerable = instance as IEnumerable;
    //    List<object> all = asEnumerable.Cast<object>().ToList();
    //    foreach (int item in items)
    //    {
    //        Assert.IsTrue(internalState.Contains(item));
    //        Assert.IsTrue(all.Contains(item));
    //    }
    //}

    public class TestAbstractBinaryHeap : AbstractBinaryHeap<int>
    {
        private readonly Func<int, int, bool> _comparer;

        public TestAbstractBinaryHeap(int initialCapacity,
            Func<int, int, bool> comparer) : base(initialCapacity)
        {
            _comparer = comparer;
        }

        protected override bool LeftPrecedes(int left, int right)
        {
            return _comparer(left, right);
        }
    }
}
