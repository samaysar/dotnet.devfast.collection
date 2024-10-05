using DevFast.Net.Collection.Abstractions;
using DevFast.Net.Collection.Abstractions.Concurrent.LookUps;
using DevFast.Net.Collection.Implementations.Concurrent.LookUps;

namespace DevFast.Net.Collection.Tests.Implementations.Concurrent
{
    [TestFixture]
    public class FastDictionaryTest
    {
        [Test]
        public void FastDictionary_Is_Writable_N_Concurrency_Is_Bounded()
        {
            That(new FastDictionary<int, int>().IsReadOnly, Is.False);
            That(new FastDictionary<int, int>().PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, Environment.ProcessorCount)));
            That(new FastDictionary<int, int>(0, int.MinValue).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 0).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 1).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 2).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, FixedValues.MinConcurrencyLevel)));
            That(new FastDictionary<int, int>(0, 3).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 4)));
            That(new FastDictionary<int, int>(0, 63).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 64)));
            That(new FastDictionary<int, int>(0, 127).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 128)));
            That(new FastDictionary<int, int>(0, 128).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 128)));
            That(new FastDictionary<int, int>(0, 129).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, 255).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, 256).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, 257).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 256)));
            That(new FastDictionary<int, int>(0, int.MaxValue).PartitionCount,
                Is.EqualTo(Math.Min(FixedValues.FastDictionaryMaxConcurrencyLevel, 256)));
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
    }
}