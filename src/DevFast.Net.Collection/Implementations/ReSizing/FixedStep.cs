using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Collection.Implementations.ReSizing
{
    /// <summary>
    /// ReSizing Strategy dictating that the collection should increase its capacity by fixed size step.
    /// </summary>
    /// <remarks>
    /// Ctor with step size.
    /// </remarks>
    /// <param name="stepSize">Step size for the increments.</param>
    /// <exception cref="ArgumentException">When step size is zero (0) or negative.</exception>
    public sealed class FixedStep(int stepSize) : IResizeStrategy
    {
        private readonly int _stepSize = stepSize.ThrowArgumentExceptionOnPredicateFail(static x => x > 0, nameof(stepSize), "'value > 0'");

        /// <summary>
        /// New size is simply the sum of the initial fixed step size and current capacity.
        /// Returns false in case of overflow.
        /// </summary>
        /// <param name="currentSize">Current size of the heap</param>
        /// <param name="newSize">outs new size</param>
        public bool TryComputeNewSize(in long currentSize, out int newSize)
        {
#if NET6_0_OR_GREATER
            long newVal = Math.Min(currentSize + _stepSize, Array.MaxLength);
#else
            long newVal = Math.Min(currentSize + _stepSize, int.MaxValue);
#endif
            newSize = (int)newVal;
            return !currentSize.Equals(newVal);
        }

        /// <inheritdoc />
        public bool CanResize => true;
    }
}
