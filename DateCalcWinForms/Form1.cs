using CalculatorBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalcWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateCalculator = new CalcLogic();
        }

        public CalcLogic dateCalculator { get; set; }

        private void CalculateButtonClicked(object sender, EventArgs e)
        {
            String unitSelected = UnitSelector.Text;
            if (unitSelected == "Days")
            {
                var difference = dateCalculator.DifferenceOfDatesInDays(DatePicker1.Value, DatePicker2.Value);
                OutputLabel.Text = difference.ToString() + " Days";
                HistoryTable.Rows.Add(DateTime.Now.ToString("H:mm:ss"), DatePicker1.Value.ToString("MMMM dd, yyyy"), DatePicker2.Value.ToString("MMMM dd, yyyy"), difference, "Days");
                ErrorLabel.Text = "";
            }
            else if (unitSelected == "Months")
            {
                var difference = dateCalculator.DifferenceOfDatesInMonths(DatePicker1.Value, DatePicker2.Value);
                OutputLabel.Text = difference.ToString() + " Months";
                HistoryTable.Rows.Add(DateTime.Now.ToString("H:mm:ss"), DatePicker1.Value.ToString("MMMM dd, yyyy"), DatePicker2.Value.ToString("MMMM dd, yyyy"), difference, "Months");
                ErrorLabel.Text = "";
            }
            else if (unitSelected == "Years")
            {
                var difference = dateCalculator.DifferenceOfDatesInYears(DatePicker1.Value, DatePicker2.Value);
                OutputLabel.Text = difference.ToString() + " Years";
                HistoryTable.Rows.Add(DateTime.Now.ToString("H:mm:ss"), DatePicker1.Value.ToString("MMMM dd, yyyy"), DatePicker2.Value.ToString("MMMM dd, yyyy"), difference, "Years");
                ErrorLabel.Text = "";
            }
            else 
            {
                ErrorLabel.Text = "Please select a valid unit you'd like your answer in";
                return;
            }
        }
    }
}
