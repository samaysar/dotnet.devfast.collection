namespace DevFast.Net.Collection.Abstractions;

/// <summary>
/// Interface exposing sizing strategy for any collection that can be resized.
/// </summary>
public interface IResizeStrategy
{
    /// <summary>
    /// Calculates the new size, based on the given value of current size.
    /// </summary>
    /// <param name="currentSize">Current size</param>
    /// <param name="newSize">New size</param>
    bool TryComputeNewSize(in long currentSize, out int newSize);

    /// <summary>
    /// Gets the truth value whether new size can be computed.
    /// </summary>
    bool CanResize { get; }
}