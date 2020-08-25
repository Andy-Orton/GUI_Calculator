using System;

namespace CalculatorBase
{
    public class CalcLogic
    {
        public double DifferenceOfDates(DateTime a, DateTime b)
        {
            return Math.Abs((a-b).TotalDays);
        }
    }
}
