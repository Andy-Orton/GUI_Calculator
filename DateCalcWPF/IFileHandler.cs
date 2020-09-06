using DateCalcWPF.Model;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;

namespace DateCalcWPF
{
    public interface IFileHandler
    {
        IEnumerable<CalculatorInput> ReadFromExcel(string path);
        void PostToExcel(ObservableCollection<CalculatorHistory> calculatorInputs);

    }


    public class FileHandler : IFileHandler
    {
        bool FileExists(string path) => File.Exists(path);
        public void PostToExcel(ObservableCollection<CalculatorHistory> calculatorInputs)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File | *.xlsx";
            saveFileDialog.ShowDialog();
            if(saveFileDialog.OverwritePrompt == true)
            {
                File.Delete(saveFileDialog.FileName);
            }
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            var newFile = new FileInfo("Export");
            using (ExcelPackage package = new ExcelPackage(new FileInfo(saveFileDialog.FileName)))
            {
                var sheet = package.Workbook.Worksheets.Add("Export");
                sheet.Cells[1, 1].Value = "First Date";
                sheet.Cells[1, 2].Value = "Second Date";
                sheet.Cells[1, 3].Value = "Difference";
                sheet.Cells[1, 4].Value = "Units";

                var row = 1;
                foreach(var histor in calculatorInputs)
                {
                    row++;
                    sheet.Cells[row, 1].Value = histor.firstDateTime;
                    sheet.Cells[row, 2].Value = histor.secondDateTime;
                    sheet.Cells[row, 3].Value = histor.output;
                    sheet.Cells[row, 4].Value = histor.units;
                }

                sheet.Tables.Add(sheet.Cells[1, 1, row, 4], "ExportTable");
                sheet.Column(1).Width = 20;
                sheet.Column(2).Width = 20;
                sheet.Column(3).Width = 17;
                sheet.Column(3).Width = 15;
                

                package.Save();

            }
        }

        public IEnumerable<CalculatorInput> ReadFromExcel(string path)
        {
            if (FileExists(path)){
                var rows = new List<CalculatorInput>();
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
                {
                    var sheet = package.Workbook.Worksheets.First();
                    for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                    {
                        DateTime firstDateTime = new DateTime((int)(double)sheet.Cells[row, 3].Value, (int)(double)sheet.Cells[row, 2].Value, (int)(double)sheet.Cells[row, 1].Value);
                        DateTime secondDateTime = new DateTime((int)(double)sheet.Cells[row, 6].Value, (int)(double)sheet.Cells[row, 5].Value, (int)(double)sheet.Cells[row, 4].Value);
                        string unit = (string)sheet.Cells[row, 7].Value;
                        rows.Add(new CalculatorInput(firstDateTime, secondDateTime, unit));
                    }
                }
                return rows;
            }
            return null;
            
        }
    }
}
