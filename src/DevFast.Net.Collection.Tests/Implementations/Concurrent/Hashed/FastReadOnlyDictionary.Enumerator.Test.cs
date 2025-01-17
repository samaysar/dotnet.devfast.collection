﻿using DevFast.Net.Collection.Implementations.Concurrent.Hashed;
using System.Collections;

namespace DevFast.Net.Collection.Tests.Implementations.Concurrent.Hashed
{
    [TestFixture]
    public class FastReadOnlyDictionaryEnumeratorTest
    {
        [Test]
        public void FastReadOnlyDicionary_When_Empty_Returns_Enumerable_Of_Zero_Count()
        {
            IEnumerable<KeyValuePair<int, int>> dictionary = new FastDictionary<int, int>().ToReadOnlyAndClear();
            That(dictionary.Count(), Is.EqualTo(0));
            IEnumerable asEnumerable = dictionary;
            IEnumerator de = asEnumerable.GetEnumerator();
            while (de.MoveNext())
            {
                throw new Exception("Enumerator should have returned FALSE");
            }
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(63)]
        [TestCase(511)]
        [TestCase(1000)]
        public void FastReadOnlyDicionary_Enumerator_Reset_Works_Fine(int totalElement)
        {
            FastDictionary<int, int> dictionary = new();
            for (int i = 0; i < totalElement; i++)
            {
                dictionary[i] = 2;
            }
            Collection.Abstractions.Concurrent.Hashed.IFastReadOnlyDictionary<int, int> dico = dictionary.ToReadOnlyAndClear();
            That(dico, Has.Count.EqualTo(totalElement));
            using IEnumerator<KeyValuePair<int, int>> de = dico.GetEnumerator();
            int count = 0;
            while (de.MoveNext())
            {
                That(de.Current.Key, Is.LessThan(totalElement));
                That(de.Current.Key, Is.GreaterThanOrEqualTo(0));
                That(de.Current.Value, Is.EqualTo(2));
                count++;
            }
            That(count, Is.EqualTo(totalElement));
            de.Reset();
            count = 0;
            while (de.MoveNext())
            {
                That(de.Current.Key, Is.LessThan(totalElement));
                That(de.Current.Key, Is.GreaterThanOrEqualTo(0));
                That(de.Current.Value, Is.EqualTo(2));
                count++;
            }
            That(count, Is.EqualTo(totalElement));
        }

        [Test]
        public void FastReadOnlyDicionary_Enumerator_Once_Dispose_Always_Yields_False_On_MoveNext()
        {
            using IEnumerator<KeyValuePair<int, int>> de = new FastDictionary<int, int>
            {
                {1,1}
            }.ToReadOnlyAndClear().GetEnumerator();
            IEnumerator oe = de;
            int count = 0;
            while (oe.MoveNext())
            {
                That(oe.Current, Is.Not.Null);
                count++;
            }
            That(count, Is.EqualTo(1));
            oe.Reset();
            de.Dispose();
            count = 0;
            while (oe.MoveNext())
            {
                throw new Exception("Enumerator should have returned FALSE");
            }
            That(count, Is.EqualTo(0));
        }
    }
}
