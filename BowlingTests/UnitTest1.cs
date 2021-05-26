using NUnit.Framework;
using Bowling;

namespace BowlingTests
{
    public class BowlingCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase("12345123451234512345", 60)]
        //[TestCase("XXXXXXXXX3-", 213)]
        [TestCase("XXXXXXXXXXXX", 300)]
        [TestCase("9-9-9-9-9-9-9-9-9-9-", 90)]
        [TestCase("5/5/5/5/5/5/5/5/5/5/5", 150)]
        [TestCase("3/5/5/5/5/5/5/5/5/5/5", 150)]
        public void CalcTests(string sequence, int result)
        {
            var calc = new BowlingCalculator();
            Assert.AreEqual(result, calc.CalculateScore(sequence));
        }
    }
}