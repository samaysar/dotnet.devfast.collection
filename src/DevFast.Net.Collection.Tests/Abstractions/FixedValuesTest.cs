using DevFast.Net.Collection.Abstractions;

namespace DevFast.Net.Collection.Tests.Abstractions
{
    [TestFixture]
    public class FixedValuesTest
    {
        [Test]
        public void Values_Are_As_Expected()
        {
            That(FixedValues.MinInitialCapacity, Is.EqualTo(0));
            That(FixedValues.MinConcurrencyLevel, Is.EqualTo(2));
            That(FixedValues.HashedCollectionMaxConcurrencyLevel, Is.EqualTo(256));
        }
    }
}
