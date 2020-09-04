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
using Microsoft.Win32;

namespace DateCalcWPF.Calculator
{
    public class CalculatorViewModel : BindableBase
    {
        public CalculatorViewModel()
        {
            //calculateCommand = new CalculateCommand(OnCalculate);
            firstDay = secondDay = 1;
            firstYear = secondYear = 2020;

        }


        private string totalDiff;
        public string TotalDiff
        {
            get => totalDiff;
            set { SetProperty(ref totalDiff, value); }
        }
        public string UnitChoice { get; set; }
        public int firstDay { get; set; }
        public int firstSelectedMonth { get; set; }
        public int firstYear { get; set; }
        public int secondDay { get; set; }
        public int secondSelectedMonth { get; set; }
        public int secondYear { get; set; }

        public List<string> Months
        {
            get => months;
        }

        private readonly List<string> months = new List<string>()
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

        private DelegateCommand calculateCommand;
        public DelegateCommand CalculateCommand => calculateCommand ?? (calculateCommand = new DelegateCommand(async () =>
        {
            //giving basic initializations
            DateTime firstDateTime = DateTime.Now;
            DateTime secondDateTime = DateTime.Now;
            try
            {
                firstDateTime = new DateTime(firstYear, firstSelectedMonth + 1, firstDay);
                secondDateTime = new DateTime(secondYear, secondSelectedMonth + 1, secondDay);
            }
            catch (ArgumentOutOfRangeException e)
            {

                MessageBox.Show(e.Message);
                return;
            }
            CalcLogic calc = new CalcLogic();
            if (UnitChoice == null)
            {
                return;
            }
            else if (UnitChoice.Contains("Days"))
            {
                TotalDiff = calc.DifferenceOfDatesInDays(firstDateTime, secondDateTime).ToString() + " days";
            }
            else if (UnitChoice.Contains("Months"))
            {
                TotalDiff = calc.DifferenceOfDatesInMonths(firstDateTime, secondDateTime).ToString() + " Months";
            }
            else if (UnitChoice.Contains("Years"))
            {
                TotalDiff = calc.DifferenceOfDatesInYears(firstDateTime, secondDateTime).ToString() + " Years";
            }
        }));

        private DelegateCommand fileFinder;
        public DelegateCommand FileFinder => fileFinder ?? (fileFinder = new DelegateCommand(async () =>
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {

            }
        }));
    }
}
