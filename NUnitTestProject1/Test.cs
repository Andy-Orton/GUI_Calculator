using CalculatorBase;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        private CalcLogic calc;
        [SetUp]
        public void Setup()
        {
            calc = new CalcLogic();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }
    }
}