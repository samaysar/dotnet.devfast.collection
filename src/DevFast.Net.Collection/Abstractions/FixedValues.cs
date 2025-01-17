﻿namespace DevFast.Net.Collection.Abstractions;

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

    /// <summary>
    /// Runtime environment processor count with minimum bound set to <see cref="MinConcurrencyLevel"/>.
    /// </summary>
    public static int ProcessorCountWithMinBound => Math.Max(MinConcurrencyLevel, Environment.ProcessorCount);

    internal static int ToPow2HashMask(this int concurrencyLevel)
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
