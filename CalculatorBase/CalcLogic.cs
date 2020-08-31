using System;

namespace CalculatorBase
{
    public class CalcLogic
    {
        public double DifferenceOfDatesInDays(DateTime a, DateTime b)
        {
            return Math.Round(Math.Abs((a-b).TotalDays));
        }

        public double DifferenceOfDatesInMonths(DateTime a, DateTime b)
        {
            return Math.Round((Math.Abs((a-b).TotalDays/(365.12/12))), 3);
        }

        public double DifferenceOfDatesInYears(DateTime a, DateTime b)
        {
            return Math.Round((Math.Abs((a - b).TotalDays / 365)), 3);
        }
    }
}
