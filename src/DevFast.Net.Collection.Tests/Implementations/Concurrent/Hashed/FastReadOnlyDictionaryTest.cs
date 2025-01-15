using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Implementations.Concurrent.Hashed;
using System.Collections.Concurrent;

namespace DevFast.Net.Collection.Tests.Implementations.Concurrent.Hashed;

[TestFixture]
public class FastReadOnlyDictionaryTest
{
    [Test]
    public void FastReadOnlyDictionary_Is_Writable_N_Concurrency_Is_Bounded()
    {
        That(new FastReadOnlyDictionary<int, int>(Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, Environment.ProcessorCount)));
        That(new FastReadOnlyDictionary<int, int>(0, int.MinValue, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
        That(new FastReadOnlyDictionary<int, int>(0, 0, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
        That(new FastReadOnlyDictionary<int, int>(0, 1, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
        That(new FastReadOnlyDictionary<int, int>(0, 2, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
        That(new FastReadOnlyDictionary<int, int>(0, 3, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 4)));
        That(new FastReadOnlyDictionary<int, int>(0, 63, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 64)));
        That(new FastReadOnlyDictionary<int, int>(0, 127, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 128)));
        That(new FastReadOnlyDictionary<int, int>(0, 128, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 128)));
        That(new FastReadOnlyDictionary<int, int>(0, 129, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
        That(new FastReadOnlyDictionary<int, int>(0, 255, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
        That(new FastReadOnlyDictionary<int, int>(0, 256, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
        That(new FastReadOnlyDictionary<int, int>(0, 257, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
        That(new FastReadOnlyDictionary<int, int>(0, int.MaxValue, Array.Empty<KeyValuePair<int, int>>(), false).PartitionCount,
            Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
    }

    [Test]
    public void FastReadOnlyDictionary_PrePopulation_Works_Using_Normal_Dictionary()
    {
        ConcurrentDictionary<int, int> normalDico = new();
        _ = normalDico.TryAdd(0, 1);
        _ = normalDico.TryAdd(1, 1);
        _ = normalDico.TryAdd(2, 1);
        FastReadOnlyDictionary<int, int> dico = new(3, 2, EqualityComparer<int>.Default, normalDico, false);
        That(dico.Count, Is.EqualTo(3));
        _ = Parallel.For(0, dico.PartitionCount, i =>
        {
            foreach (KeyValuePair<int, int> kvp in dico.EnumerableOnPartition(i))
            {
                That(normalDico.TryRemove(kvp.Key, out int value), Is.True);
                That(value, Is.EqualTo(1));
            }
        });
        That(normalDico, Is.Empty);
        FastReadOnlyDictionary<int, int> copyDico = dico;
        dico = new(3, 2, EqualityComparer<int>.Default, copyDico, false);
        That(dico.Count, Is.EqualTo(3));
        _ = Parallel.For(0, dico.PartitionCount, i =>
        {
            foreach (KeyValuePair<int, int> kvp in dico.EnumerableOnPartition(i))
            {
                That(kvp.Key, Is.LessThanOrEqualTo(2));
                That(kvp.Key, Is.GreaterThanOrEqualTo(0));
                That(kvp.Value, Is.EqualTo(1));
            }
        });
    }

    [Test]
    [TestCase(1)]
    [TestCase(10)]
    [TestCase(100)]
    [TestCase(1023)]
    [TestCase(9735)]
    public void FastReadOnlyDictionary_CountInPartition_Is_Consistent(int totalElements)
    {
        FastReadOnlyDictionary<int, int> dico = new(totalElements,
            Environment.ProcessorCount,
            EqualityComparer<int>.Default,
            Enumerable.Range(0, totalElements).Select(x => new KeyValuePair<int, int>(x, x)),
            false);
        int dicoCount = dico.Count;
        That(dicoCount, Is.EqualTo(totalElements));
        _ = Parallel.For(0, dico.PartitionCount, i =>
        {
            _ = Interlocked.Add(ref dicoCount, -dico.CountInPartition(i));
        });
        That(dicoCount, Is.Zero);
    }

    [Test]
    public void FastReadOnlyDictionary_PrePopulation_Works_Using_Kvp_Collection()
    {
        FastReadOnlyDictionary<int, int> dico = new(3, 2, EqualityComparer<int>.Default, new[] {
                new KeyValuePair<int, int>(0,1),
                new KeyValuePair<int, int>(1,1),
                new KeyValuePair<int, int>(2,1),
                new KeyValuePair<int, int>(2,2)
        }, true);
        That(dico.Count, Is.EqualTo(3));
        That(dico.Contains(new KeyValuePair<int, int>(0, 1)), Is.True);
        That(dico.Contains(new KeyValuePair<int, int>(1, 1)), Is.True);
        That(
            dico.Contains(new KeyValuePair<int, int>(2, 1)) ||
            dico.Contains(new KeyValuePair<int, int>(2, 2)),
            Is.True
        );

        AggregateException? ex = Throws<AggregateException>(() => new FastReadOnlyDictionary<int, int>(3, 2, EqualityComparer<int>.Default, new[] {
                new KeyValuePair<int, int>(0,1),
                new KeyValuePair<int, int>(1,1),
                new KeyValuePair<int, int>(2,1),
                new KeyValuePair<int, int>(2,2)
        }, false));
        That(ex, Is.Not.Null);
    }
}
