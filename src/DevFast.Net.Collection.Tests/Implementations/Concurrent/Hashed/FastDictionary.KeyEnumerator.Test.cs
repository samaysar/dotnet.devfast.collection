﻿using DevFast.Net.Collection.Implementations.Concurrent.Hashed;
using System.Collections;

namespace DevFast.Net.Collection.Tests.Implementations.Concurrent.Hashed
{
    [TestFixture]
    public class FastDictionaryKeyEnumeratorTest
    {
        [Test]
        public void FastDicionary_When_Empty_Returns_KeyEnumerable_Of_Zero_Count()
        {
            IEnumerable<int> dictionary = new FastDictionary<int, int>().EnumerableOfKeys();
            That(dictionary.Count(), Is.EqualTo(0));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(63)]
        [TestCase(511)]
        [TestCase(1000)]
        public void FastDicionary_KeyEnumerator_Reset_Works_Fine(int totalElement)
        {
            FastDictionary<int, int> dictionary = new();
            for (int i = 0; i < totalElement; i++)
            {
                dictionary[i] = 2;
            }
            That(dictionary, Has.Count.EqualTo(totalElement));
            using IEnumerator<int> de = dictionary.EnumerableOfKeys().GetEnumerator();
            int count = 0;
            while (de.MoveNext())
            {
                That(de.Current, Is.LessThan(totalElement));
                count++;
            }
            That(count, Is.EqualTo(totalElement));
            de.Reset();
            count = 0;
            while (de.MoveNext())
            {
                That(de.Current, Is.LessThan(totalElement));
                count++;
            }
            That(count, Is.EqualTo(totalElement));
        }

        [Test]
        public void FastDicionary_KeyEnumerator_Once_Dispose_Always_Yields_False_On_MoveNext()
        {
            using IEnumerator<int> de = new FastDictionary<int, int>
            {
                {1,1}
            }.EnumerableOfKeys().GetEnumerator();
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

            That(((IEnumerable)new FastDictionary<int, int>
            {
                {1,1}
            }.EnumerableOfKeys()).GetEnumerator(), Is.Not.Null);
        }
    }
}
