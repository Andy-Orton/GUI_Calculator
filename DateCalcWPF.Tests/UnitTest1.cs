using DateCalcWPF.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace DateCalcWPF.Tests
{
    public class Tests
    {
        public FileHandler fileHandler { get; set; }
        [SetUp]
        public void Setup()
        {
            fileHandler = new FileHandler();
        }

        
        [Test]
        public void TestFileRead()
        {
            //to run tests find where the spreadsheet is located on your system couldn't figure out relative paths
            string path = @"C:\Users\andel\GUI_Calculator\TestSpreadsheet.xlsx";
            Assert.IsTrue(File.Exists(path));
            List<CalculatorInput> calcInputs = fileHandler.ReadFromExcel(path).ToList();
            CalculatorInput correctInput = new CalculatorInput(
                new System.DateTime(2020, 1, 1), 
                new System.DateTime(2020, 1, 2), 
                "Days");
            Assert.AreEqual(calcInputs[0].firstDateTime, correctInput.firstDateTime);
            Assert.AreEqual(calcInputs[0].secondDateTime, correctInput.secondDateTime);
            Assert.AreEqual(calcInputs[0].units, correctInput.units);
        }

        [Test]
        public void TestFileWrite()
        {
            CalculatorHistory correctInput = new CalculatorHistory(
                   new System.DateTime(2020, 1, 1).ToString(),
                   new System.DateTime(2020, 1, 2).ToString(),
                   "Days",
                   1.0); ;
            ObservableCollection<CalculatorHistory> calculatorInputs = new ObservableCollection<CalculatorHistory>();
            calculatorInputs.Add(correctInput);
            fileHandler.PostToExcel(calculatorInputs);
        }
    }
}