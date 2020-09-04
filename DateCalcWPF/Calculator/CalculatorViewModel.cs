using DateCalcWPF.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using System.ComponentModel;
using System.Diagnostics;
using Prism.Mvvm;
using System.Windows;
using CalculatorBase;

namespace DateCalcWPF.Calculator
{
    public class CalculatorViewModel : BindableBase
    {
        public CalculatorViewModel()
        {
            //calculateCommand = new CalculateCommand(OnCalculate);
        }

        public int firstSelectedMonth { get; set; }

        private string totalDiff;
        public string TotalDiff
        {
            get => totalDiff;
            set { SetProperty(ref totalDiff, value); }
        }

        public int firstDay { get; set; }
        public int firstMonth { get; set; }
        public int firstYear { get; set; }
        public int secondDay { get; set; }
        public int secondMonth { get; set; }
        public int secondYear { get; set; }

        private DelegateCommand calculateCommand;
        public DelegateCommand CalculateCommand => calculateCommand ?? (calculateCommand = new DelegateCommand(async () =>
        {
            Debug.Write(firstSelectedMonth);
            DateTime firstDateTime = DateTime.Now;
            DateTime secondDateTime = DateTime.Now;
            try
            {
                firstDateTime = new DateTime(firstYear, (firstSelectedMonth + 1), firstDay);
                secondDateTime = new DateTime(secondYear, secondMonth, secondDay);
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message);
            }
            CalcLogic calc = new CalcLogic();
            if ((firstDateTime.Day - secondDateTime.Day) != 0)
            {
                var x = calc.DifferenceOfDatesInDays(firstDateTime, secondDateTime);
                TotalDiff = x + " days";
            }
        }));

        public List<string> Months = new List<string>() 
        {   "January", 
            "February", 
            "March",
            "April", 
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"};
    }
}
