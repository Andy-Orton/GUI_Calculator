using CalculatorBase;
using NUnit.Framework;
using System;

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
        public void DayTest()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2000, 1, 3);
            Assert.AreEqual(2.0, calc.DifferenceOfDates(dateTime, dateTime1));
        }
        [Test]
        public void MonthTest()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2000, 2, 1);
            Assert.AreEqual(31, calc.DifferenceOfDates(dateTime, dateTime1));
        }
        [Test]
        public void YearTest()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2001, 1, 1);
            Assert.AreEqual(366, calc.DifferenceOfDates(dateTime, dateTime1));
        }
    }
}