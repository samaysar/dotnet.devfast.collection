namespace DevFast.Net.Collection.Abstractions;

/// <summary>
/// A wrapper class holding constant values.
/// </summary>
public static class FixedValues
{
    /// <summary>
    /// Minimum bound on initial capacity.
    /// </summary>
    public const int MinInitialCapacity = 0;

    /// <summary>
    /// Minimum bound on concurrency level.
    /// </summary>
    public const int MinConcurrencyLevel = 2;

    /// <summary>
    /// Maximum bound on concurrency level.
    /// </summary>
    public const int HashedCollectionMaxConcurrencyLevel = 256;

    internal static int ToConcurrencyHash(this int concurrencyLevel)
    {
        int currentPow2 = 2;
        while (concurrencyLevel > currentPow2 &&
            currentPow2 < HashedCollectionMaxConcurrencyLevel)
        {
            currentPow2 <<= 1;
        }
        return currentPow2 - 1;
    }
}
