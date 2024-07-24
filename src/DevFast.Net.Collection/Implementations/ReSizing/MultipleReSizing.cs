using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Collection.Implementations.ReSizing;

/// <summary>
/// ReSizing Strategy dictating that the collection should increase its capacity in multiple.
/// </summary>
/// <remarks>
/// Ctor with multiplier.
/// </remarks>
/// <param name="multiple">Size multiple.</param>
/// <exception cref="ArgumentException">When step size is zero (0) or negative.</exception>
public sealed class MultipleReSizing(double multiple) : IResizeStrategy
{
    private readonly double _multiple = multiple.ThrowArgumentExceptionOnPredicateFail(static x => x > 1, nameof(multiple), "'value > 1'");

    /// <summary>
    /// New size is increased by multiple, with lower bound to <paramref name="currentSize"/>+1.
    /// </summary>
    /// <param name="currentSize">Current size of the heap</param>
    /// <param name="newSize">outs new size</param>
    public bool TryComputeNewSize(in long currentSize, out int newSize)
    {
#if NET6_0_OR_GREATER
        long newVal = Math.Min(Math.Max(currentSize + 1, (long)(currentSize * _multiple)), Array.MaxLength);
#else
        long newVal = Math.Min(Math.Max(currentSize + 1, (long)(currentSize * _multiple)), int.MaxValue);
#endif
        newSize = (int)newVal;
        return !currentSize.Equals(newVal);
    }

    /// <inheritdoc />
    public bool CanResize => true;
}
