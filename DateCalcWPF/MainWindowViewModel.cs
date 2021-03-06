﻿using CalculatorBase;
using DateCalcWPF.Model;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;

namespace DateCalcWPF
{
    public class MainWindowViewModel : BindableBase
    {

        public MainWindowViewModel()
        {
            Title = "Date Calculator";
            firstDay = secondDay = 1;
            firstYear = secondYear = 2020;
            CalculatorInputs = new ObservableCollection<CalculatorHistory>();
            fileHandler = new FileHandler();
        }

        public IFileHandler fileHandler { get; set; }

        private ObservableCollection<CalculatorHistory> calculatorInputs;
        public ObservableCollection<CalculatorHistory> CalculatorInputs
        {
            get => calculatorInputs;
            set { SetProperty(ref calculatorInputs, value); }
        }

        private string title;
        public string Title
        {
            get => title;
            set { SetProperty(ref title, value); }
        }


        private string fileName;
        public string FileName
        {
            get => fileName;
            set { SetProperty(ref fileName, value); }
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
        public DelegateCommand CalculateCommand => calculateCommand ?? (calculateCommand = new DelegateCommand(() =>
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
                var difference = calc.DifferenceOfDatesInDays(firstDateTime, secondDateTime);
                TotalDiff = difference.ToString() + " days";
                calculatorInputs.Add(new CalculatorHistory(firstDateTime.ToString(), secondDateTime.ToString(), "Days", difference));
            }
            else if (UnitChoice.Contains("Months"))
            {
                var difference = calc.DifferenceOfDatesInMonths(firstDateTime, secondDateTime);
                TotalDiff = difference.ToString() + " months";
                var firstString = firstDateTime.ToString();
                var secondString = secondDateTime.ToString();
                calculatorInputs.Add(new CalculatorHistory(firstString, secondString, "Months", difference));
            }
            else if (UnitChoice.Contains("Years"))
            {
                var difference = calc.DifferenceOfDatesInYears(firstDateTime, secondDateTime);
                TotalDiff = difference.ToString() + " years";
                calculatorInputs.Add(new CalculatorHistory(firstDateTime.ToString(), secondDateTime.ToString(), "Years", difference));
            }

        }));

        private DelegateCommand fileFinder;
        public DelegateCommand FileFinder => fileFinder ?? (fileFinder = new DelegateCommand(() =>
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                FileName = openFile.FileName;
            }
        }));

        private DelegateCommand fileCalculate;
        public DelegateCommand FileCalculate => fileCalculate ?? (fileCalculate = new DelegateCommand(() =>
        {
            if (FileName == null)
            {
                return;
            }
            List<CalculatorInput> calculatorHistory = fileHandler.ReadFromExcel(FileName).ToList();
            if (calculatorHistory == null)
            {
                return;
            }
            CalcLogic calc = new CalcLogic();
            foreach (CalculatorInput x in calculatorHistory)
            {
                if (x.units == null)
                {
                    return;
                }
                else if (x.units.Contains("Days"))
                {
                    var difference = calc.DifferenceOfDatesInDays(x.firstDateTime, x.secondDateTime);
                    calculatorInputs.Add(new CalculatorHistory(x.firstDateTime.ToString(), x.secondDateTime.ToString(), x.units, difference));
                }
                else if (x.units.Contains("Months"))
                {
                    var difference = calc.DifferenceOfDatesInMonths(x.firstDateTime, x.secondDateTime);
                    var firstString = x.firstDateTime.ToString();
                    var secondString = x.secondDateTime.ToString();
                    calculatorInputs.Add(new CalculatorHistory(firstString, secondString, "Months", difference));
                }
                else if (x.units.Contains("Years"))
                {
                    var difference = calc.DifferenceOfDatesInYears(x.firstDateTime, x.secondDateTime);
                    TotalDiff = difference.ToString() + " years";
                    calculatorInputs.Add(new CalculatorHistory(x.firstDateTime.ToString(), x.secondDateTime.ToString(), "Years", difference));
                }
            }
        }));

        private DelegateCommand saveToExcel;
        public DelegateCommand SaveToExcel => saveToExcel ?? (saveToExcel = new DelegateCommand(() =>
        {
            fileHandler.PostToExcel(CalculatorInputs);
        }));
    }
}

