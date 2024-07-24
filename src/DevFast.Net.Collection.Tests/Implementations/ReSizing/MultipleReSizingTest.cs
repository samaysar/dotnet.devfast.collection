using DevFast.Net.Collection.Implementations.ReSizing;

namespace DevFast.Net.Collection.Tests.Implementations.ReSizing;

[TestFixture]
public class MultipleReSizingTest
{
    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(0.5)]
    [TestCase(1)]
    public void Ctor_Throws_ArgumentException_When_Step_Is_Zero_Or_Negative(double multiple1OrLessThan1)
    {
        Ae? ex = Throws<ArgumentException>(() => new MultipleReSizing(multiple1OrLessThan1));
        That(ex, Is.Not.Null);
        That(ex!.Message, Is.EqualTo("multiple does not satisfy 'value > 1'."));
    }

    [Test]
    public void CanResize_Always_Returns_True()
    {
        That(new MultipleReSizing(1.5).CanResize, Is.True);
    }

    [Test]
    [TestCase(1.01, 0, 1)]
    [TestCase(1.01, 10, 11)]
    [TestCase(1.01, 1000, 1010)]
    [TestCase(1.10, 0, 1)]
    [TestCase(1.10, 10, 11)]
    [TestCase(1.10, 1000, 1100)]
    public void TryComputeNewSize_Calculates_Good_NewSize(double multiple, int current, int expected)
    {
        MultipleReSizing instance = new(multiple);
        That(instance.TryComputeNewSize(current, out int newSize), Is.True);
        That(newSize, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1.01)]
    [TestCase(1.10)]
    public void TryComputeNewSize_Behaves_Well_On_Boundary_Condition(double multiple)
    {
        MultipleReSizing instance = new(multiple);
#if NET6_0_OR_GREATER
        That(instance.TryComputeNewSize(Array.MaxLength - 1, out int newSize), Is.True);
        That(newSize, Is.EqualTo(Array.MaxLength));
        That(instance.TryComputeNewSize(Array.MaxLength, out newSize), Is.False);
        That(newSize, Is.EqualTo(Array.MaxLength));
#else
        That(instance.TryComputeNewSize(int.MaxValue - 1, out int newSize), Is.True);
        That(newSize, Is.EqualTo(int.MaxValue));
        That(instance.TryComputeNewSize(int.MaxValue, out newSize), Is.False);
        That(newSize, Is.EqualTo(int.MaxValue));
#endif        
    }
}
