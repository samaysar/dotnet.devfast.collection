using DevFast.Net.Collection.Abstractions;

namespace DevFast.Net.Collection.Implementations.ReSizing
{
    /// <summary>
    /// ReSizing Strategy dictating that the collection created with fixed capacity must NOT be resized.
    /// </summary>
    public sealed class NoResizing : IResizeStrategy
    {
        /// <summary>
        /// Unique instance of the class.
        /// </summary>
        public static readonly NoResizing Default = new();

        private NoResizing() { }

        /// <summary>
        /// Calling this method will always returns false.
        /// </summary>
        /// <param name="currentSize">Current size of the heap</param>
        /// <param name="newSize">Always outs Default int value</param>
        public bool TryComputeNewSize(in long currentSize, out int newSize)
        {
            newSize = 0;
            return false;
        }

        /// <inheritdoc />
        public bool CanResize => false;
    }
}
