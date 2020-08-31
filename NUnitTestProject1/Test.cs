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
        public void DayInputTest()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2000, 1, 3);
            Assert.AreEqual(2.0, calc.DifferenceOfDatesInDays(dateTime, dateTime1));
        }
        [Test]
        public void MonthInputTest()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2000, 2, 1);
            Assert.AreEqual(31, calc.DifferenceOfDatesInDays(dateTime, dateTime1));
        }
        [Test]
        public void YearInputTest()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2001, 1, 1);
            Assert.AreEqual(366, calc.DifferenceOfDatesInDays(dateTime, dateTime1));
        }

        [Test]
        public void MonthOutput()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2001, 1, 1);
            Assert.AreEqual(12, calc.DifferenceOfDatesInMonths(dateTime, dateTime1), 0.1);
        }

        [Test]
        public void YearOutput()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2001, 1, 1);
            Assert.AreEqual(1, calc.DifferenceOfDatesInYears(dateTime, dateTime1), 0.01);
        }

        [Test]
        public void DecimalMonthOutput()
        {
            DateTime dateTime = new DateTime(2000, 1, 15);
            DateTime dateTime1 = new DateTime(2000, 2, 1);
            Assert.AreEqual(0.5, calc.DifferenceOfDatesInMonths(dateTime, dateTime1), 0.1);
        }

        [Test]
        public void DecimalYearOutput()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            DateTime dateTime1 = new DateTime(2001, 3, 1);
            Assert.AreEqual(1.12, calc.DifferenceOfDatesInYears(dateTime, dateTime1), 0.09);
        }
    }
}