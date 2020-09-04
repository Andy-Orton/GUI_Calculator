using DateCalcWPF.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using System.ComponentModel;
using System.Diagnostics;

namespace DateCalcWPF.Calculator
{
    public class CalculatorViewModel
    {
        public CalculatorViewModel()
        {
            //calculateCommand = new CalculateCommand(OnCalculate);
        }


        
        public string totalDiff { get; set; }

        public int firstDay { get; set; }
        public int firstMonth { get; set; }
        public int firstYear { get; set; }
        public int secondDay { get; set; }
        public int secondMonth { get; set; }
        public int secondYear { get; set; }

        private DelegateCommand calculateCommand;
        public DelegateCommand CalculateCommand => calculateCommand ?? (calculateCommand = new DelegateCommand(async () =>
        {
            totalDiff = "SAMPLE";
        }));
    }
}
