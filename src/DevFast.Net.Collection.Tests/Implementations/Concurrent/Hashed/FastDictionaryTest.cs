using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.Hashed;
using DevFast.Net.Collection.Implementations.Concurrent.Hashed;

namespace DevFast.Net.Collection.Tests.Implementations.Concurrent.Hashed
{
    [TestFixture]
    public class FastDictionaryTest
    {
        [Test]
        public void FastDictionary_Is_Writable_N_Concurrency_Is_Bounded()
        {
            That(new FastDictionary<int, int>().IsReadOnly, Is.False);
            That(new FastDictionary<int, int>().PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, Environment.ProcessorCount)));
            That(new FastDictionary<int, int>(0, int.MinValue).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 0).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 1).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 2).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 3).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 4)));
            That(new FastDictionary<int, int>(0, 63).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 64)));
            That(new FastDictionary<int, int>(0, 127).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 128)));
            That(new FastDictionary<int, int>(0, 128).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 128)));
            That(new FastDictionary<int, int>(0, 129).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, 255).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, 256).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, 257).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, int.MaxValue).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.HashedCollectionMaxConcurrencyLevel, 256)));
        }

        [Test]
        public void FastDictionary_Indexer_Works_Fine()
        {
            FastDictionary<int, int> dico = new();
            KeyNotFoundException? ex = Throws<KeyNotFoundException>(() => _ = dico[0]);
            That(ex, Is.Not.Null);
            dico[0] = 1;
            That(dico[0], Is.EqualTo(1));
            dico[0] = 0;
            That(dico[0], Is.EqualTo(0));
            That(dico, Has.Count.EqualTo(1));
        }

        [Test]
        public void FastDictionary_Key_N_Value_Enumerable_Works_Fine()
        {
            IFastDictionary<int, int> dico = new FastDictionary<int, int>();
            That(dico.Keys.Count(), Is.EqualTo(0));
            That(dico.Values.Count(), Is.EqualTo(0));
            dico[0] = 1;
            dico[1] = 2;
            That(dico.Keys, Is.EquivalentTo(new[] { 0, 1 }));
            That(dico.Values, Is.EquivalentTo(new[] { 2, 1 }));
            IReadOnlyDictionary<int, int> roDico = dico;
            That(roDico.Keys, Is.EquivalentTo(new[] { 0, 1 }));
            That(roDico.Values, Is.EquivalentTo(new[] { 2, 1 }));
        }

        [Test]
        public void FastDictionary_Add_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico, Has.Count.EqualTo(2));
            That(dico.Keys, Is.EquivalentTo(new[] { 0, 1 }));
            That(dico.Values, Is.EquivalentTo(new[] { 2, 1 }));
        }

        [Test]
        public void FastDictionary_AddOrUpdate_Works_Fine()
        {
            FastDictionary<int, int> dico = new();
            _ = dico.AddOrUpdate(0, 1, (_, __) => 1);
            That(dico[0], Is.EqualTo(1));
            _ = dico.AddOrUpdate(0, 1, (_, __) => 2);
            That(dico[0], Is.EqualTo(2));
            _ = dico.AddOrUpdate(0, 1, (_, __) =>
            {
                dico[0] = 5;
                return 3;
            });
            That(dico[0], Is.EqualTo(3));
        }

        [Test]
        public void FastDictionary_Clear_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico, Has.Count.EqualTo(2));
            dico.Clear();
            That(dico, Is.Empty);

            dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico, Has.Count.EqualTo(2));
            dico.Clear(true);
            That(dico, Is.Empty);
            dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico, Has.Count.EqualTo(2));
            dico.Clear(false);
            That(dico, Is.Empty);

            dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico, Has.Count.EqualTo(2));
            dico.Clear(0);
            That(dico, Is.Empty);
        }

        [Test]
        public void FastDictionary_Contains_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico.Contains(new KeyValuePair<int, int>(1, 2)), Is.True);
            That(!dico.Contains(new KeyValuePair<int, int>(0, 2)), Is.True);
            That(dico.Contains(new KeyValuePair<int, int>(0, 1)), Is.True);
        }

        [Test]
        public void FastDictionary_ContainsKey_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico.ContainsKey(1), Is.True);
            That(!dico.ContainsKey(2), Is.True);
            That(dico.ContainsKey(0), Is.True);
        }

        [Test]
        public void FastDictionary_CopyTo_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            KeyValuePair<int, int>[] newArr = new KeyValuePair<int, int>[2];
            dico.CopyTo(newArr, 0);
            if (newArr[0].Key.Equals(1))
            {
                That(newArr[1].Key, Is.EqualTo(0));
                That(newArr[1].Value, Is.EqualTo(1));
                That(newArr[0].Value, Is.EqualTo(2));
            }
            else
            {
                That(newArr[1].Key, Is.EqualTo(1));
                That(newArr[1].Value, Is.EqualTo(2));
                That(newArr[0].Key, Is.EqualTo(0));
                That(newArr[0].Value, Is.EqualTo(1));
            }
        }

        [Test]
        public void FastDictionary_GetOrAdd_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1)
            };
            That(dico.GetOrAdd(1, 3), Is.EqualTo(2));
            That(dico.GetOrAdd(0, 3), Is.EqualTo(1));
            That(dico.GetOrAdd(2, 3), Is.EqualTo(3));
            That(dico.GetOrAdd(2, _ => 4), Is.EqualTo(3));
            That(dico.GetOrAdd(3, _ => 4), Is.EqualTo(4));
        }

        [Test]
        public void FastDictionary_Remove_Works_Fine()
        {
            FastDictionary<int, int> dico = new()
            {
                { 1, 2 },
                new KeyValuePair<int, int>(0, 1),
                { 2, 2 }
            };
            That(dico.Remove(-1), Is.False);
            That(dico.Remove(1), Is.True);
            That(dico.Remove(new KeyValuePair<int, int>(2, 1)), Is.False);
            That(dico.Remove(new KeyValuePair<int, int>(2, 2)), Is.True);
        }

        [Test]
        public void FastDictionary_TryAdd_Works_Fine()
        {
            FastDictionary<int, int> dico = new();
            That(dico.TryAdd(1, 0), Is.True);
            That(dico.TryAdd(1, 1), Is.False);
            That(dico, Has.Count.EqualTo(1));
        }

        [Test]
        public void FastDictionary_TryGetValue_Works_Fine()
        {
            FastDictionary<int, int> dico = new();
            That(dico.TryAdd(1, 0), Is.True);
            That(dico.TryAdd(1, 1), Is.False);
            That(dico.TryGetValue(1, out int v), Is.True);
            That(v, Is.EqualTo(0));
            That(dico, Has.Count.EqualTo(1));
        }

        [Test]
        public void FastDictionary_TryRemove_Works_Fine()
        {
            FastDictionary<int, int> dico = new();
            That(dico.TryAdd(1, 0), Is.True);
            That(dico.TryAdd(1, 1), Is.False);
            That(dico.TryRemove(1, out int v), Is.True);
            That(v, Is.EqualTo(0));
            That(dico, Is.Empty);
        }

        [Test]
        public void FastDictionary_TryUpdate_Works_Fine()
        {
            FastDictionary<int, int> dico = new();
            That(dico.TryAdd(1, 0), Is.True);
            That(dico.TryAdd(1, 1), Is.False);
            That(dico.TryUpdate(1, 2, 1, null), Is.False);
            That(dico.TryUpdate(1, 2, 0, null), Is.True);
            That(dico.TryGetValue(1, out int v), Is.True);
            That(v, Is.EqualTo(2));
            That(dico, Has.Count.EqualTo(1));
        }
    }
}