using DevFast.Net.Collection.Implementations.Heaps;

namespace DevFast.Net.Collection.Tests.Implementations.Heaps;

[TestFixture]
public class MaxHeapTest
{
    [Test]
    [TestCase(-1)]
    [TestCase(int.MinValue)]
    public void MaxHeap_Ctor_Throws_Error_For_Invalid_Arguments(int capacity)
    {
        Ae? ctorEx = Assert.Throws<Ae>(() => new MaxHeap<int>(capacity));
        That(ctorEx, Is.Not.Null);
        That(ctorEx!.Message, Is.EqualTo("initialCapacity does not satisfy : 'value >= 0'."));
    }

    [Test]
    public void MaxHeap_Ctor_Do_Not_Uses_Resizing_By_Default()
    {
        That(new MaxHeap<int>(0).CanResize, Is.False);
    }

    [Test]
    [TestCase(10)]
    [TestCase(10000)]
    public void MaxHeap_Maintains_Ascending_Sorting_Order(int count)
    {
        MaxHeap<byte> instance = new(count);
        That(instance.CanResize, Is.False);
        byte[] input = new byte[count];
        new Random().NextBytes(input);
        foreach (byte val in input)
        {
            That(instance.TryAdd(val), Is.True);
        }
        That(instance.IsFull, Is.True);
        Array.Sort(input);
        Array.Reverse(input);
        foreach (byte next in input)
        {
            That(instance.TryPop(out byte val) && val.Equals(next), Is.True);
        }
        That(instance.IsEmpty, Is.True);
    }

    [Test]
    [TestCase(10)]
    [TestCase(10000)]
    public void MaxHeap_Maintains_Ascending_Sorting_Order_Input_Sorted(int count)
    {
        MaxHeap<byte> instance = new(count);
        That(instance.CanResize, Is.False);
        byte[] input = new byte[count];
        new Random().NextBytes(input);
        Array.Sort(input);
        Array.Reverse(input);
        foreach (byte val in input)
        {
            That(instance.TryAdd(val), Is.True);
        }
        That(instance.IsFull, Is.True);
        foreach (byte next in input)
        {
            That(instance.TryPop(out byte val) && val.Equals(next), Is.True);
        }
        That(instance.IsEmpty, Is.True);
    }
}