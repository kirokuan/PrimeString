using NUnit.Framework;

namespace PrimeString.Test
{
    class BandNameGeneratorTest
    {
        [TestCase("knife", ExpectedResult = "The Knife")]
        [TestCase("tart", ExpectedResult = "Tartart")]
        [TestCase("sandles", ExpectedResult = "Sandlesandles")]
        public string SimpleCase(string brand)
        {
            return (new BandNameGenerator(brand)).GetName();
        }
    }
}
