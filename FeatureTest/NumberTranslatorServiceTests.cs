using Num2Words.Services;
using NUnit.Framework;

namespace FeatureTest
{
    public class NumberTranslatorServiceTests
    {
        public NumberTranslatorService? service = null;
        [SetUp]
        public void Setup()
        {
            service = new();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}