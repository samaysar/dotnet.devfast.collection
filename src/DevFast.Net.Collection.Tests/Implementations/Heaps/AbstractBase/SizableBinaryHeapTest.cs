using System.Reflection;
using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Implementations.Heaps.AbstractBase;
using DevFast.Net.Collection.Implementations.ReSizing;

namespace DevFast.Net.Collection.Tests.Implementations.Heaps.AbstractBase;

[TestFixture]
public class SizableBinaryHeapTest
{
    [Test]
    [TestCase(-1)]
    [TestCase(int.MinValue)]
    public void Ctor_Throws_Error_For_Invalid_Capacity(int capacity)
    {
        Ae? ctorEx = Throws<TargetInvocationException>(() => For<SizableBinaryHeap<int>>(capacity))?.InnerException as Ae;
        That(ctorEx, Is.Not.Null);
        That(ctorEx!.Message, Is.EqualTo("initialCapacity does not satisfy : 'value >= 0'."));
    }

    [Test]
    public void Ctor_Throws_Error_For_Missing_Strategy()
    {
        Ae? ctorEx = Throws<TargetInvocationException>(() => For<SizableBinaryHeap<int>>(0, null))?.InnerException as Ae;
        That(ctorEx, Is.Not.Null);
        That(ctorEx!.Message, Is.EqualTo("resizeStrategy was null."));
    }

    [Test]
    public void Ctor_Properly_Sets_Properties()
    {
        SizableBinaryHeap<int> instance = For<SizableBinaryHeap<int>>(0);
        IResizeStrategy strategy = NoResizing.Default;
        That(instance.CanResize, Is.EqualTo(strategy.CanResize));
        instance = For<SizableBinaryHeap<int>>(0, strategy);
        That(instance.CanResize, Is.EqualTo(strategy.CanResize));
        strategy = new FixedStepReSizing(1);
        instance = For<SizableBinaryHeap<int>>(0, strategy);
        That(instance.CanResize, Is.EqualTo(strategy.CanResize));
        strategy = new MultipleReSizing(2);
        instance = For<SizableBinaryHeap<int>>(0, strategy);
        That(instance.CanResize, Is.EqualTo(strategy.CanResize));
    }

    [Test]
    public void FreezeCapacity_Behaves()
    {
        foreach (IResizeStrategy strategy in new IResizeStrategy[]
        {
                NoResizing.Default,
                new FixedStepReSizing(1),
                new MultipleReSizing(2)
        })
        {
            foreach (bool compact in new[] { true, false })
            {
                SizableBinaryHeap<int> instance = For<SizableBinaryHeap<int>>(0, strategy);
                That(instance.CanResize, Is.EqualTo(strategy.CanResize));
                instance.FreezeCapacity(compact);
                That(instance.CanResize, Is.False);
                instance.Received(compact ? 1 : 0).Compact();
            }
        }
    }

    [Test]
    public void UseStrategies_Properly()
    {
        IResizeStrategy strategy = For<IResizeStrategy>();
        _ = strategy.TryComputeNewSize(Arg.Any<int>(), out _)
            .Returns(x =>
            {
                x[1] = 0;
                return false;
            });
        SizableBinaryHeap<int> instance = ForPartsOf<SizableBinaryHeap<int>>(0,
            strategy);
        That(instance.IsFull, Is.True);
        That(instance.TryAdd(1), Is.False);
        _ = strategy.Received(1).TryComputeNewSize(0, out _);

        strategy = new FixedStepReSizing(1);
        instance = ForPartsOf<SizableBinaryHeap<int>>(1, strategy);
        That(instance, Has.Count.EqualTo(0));
        That(instance.IsFull, Is.False);
        That(instance.TryAdd(1), Is.True);
        That(instance.IsFull, Is.True);
        That(instance, Has.Count.EqualTo(1));
        That(instance.TryAdd(1), Is.True);
        That(instance.IsFull, Is.True);
        That(instance, Has.Count.EqualTo(2));

        instance.FreezeCapacity(false);
        That(instance.TryAdd(1), Is.False);
        That(instance.IsFull, Is.True);
        That(instance, Has.Count.EqualTo(2));
    }
}
