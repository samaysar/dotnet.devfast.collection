using DevFast.Net.Collection.Implementations.ReSizing;

namespace DevFast.Net.Collection.Tests.Implementations.ReSizing;

[TestFixture]
public class FixedStepReSizingTest
{
    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(int.MinValue)]
    public void Ctor_Throws_ArgumentException_When_Step_Is_Zero_Or_Negative(int zeroOrNegativeSize)
    {
        Ae? ex = Throws<ArgumentException>(() => new FixedStepReSizing(zeroOrNegativeSize));
        That(ex, Is.Not.Null);
        That(ex!.Message, Is.EqualTo("stepSize does not satisfy 'value > 0'."));
    }

    [Test]
    public void CanResize_Always_Returns_True()
    {
        That(new FixedStepReSizing(1).CanResize, Is.True);
    }

    [Test]
    [TestCase(1, 0, 1)]
    [TestCase(1, 10, 11)]
    [TestCase(10, 0, 10)]
    [TestCase(10, 10, 20)]
    public void TryComputeNewSize_Calculates_Good_NewSize(int step, int current, int expected)
    {
        FixedStepReSizing instance = new(step);
        That(instance.TryComputeNewSize(current, out int newSize), Is.True);
        That(newSize, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1)]
    [TestCase(10)]
    public void TryComputeNewSize_Behaves_Well_On_Boundary_Condition(int stepSize)
    {
        FixedStepReSizing instance = new(stepSize);
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
