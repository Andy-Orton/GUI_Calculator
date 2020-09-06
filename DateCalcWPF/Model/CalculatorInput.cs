using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalcWPF.Model
{
    public class CalculatorInput
    {
        public CalculatorInput(DateTime firstDateTime, DateTime secondDateTime, string units)
        {
            this.firstDateTime = firstDateTime;
            this.secondDateTime = secondDateTime;
            this.units = units;
        }

        public DateTime firstDateTime { get; set; }
        public DateTime secondDateTime { get; set; }
        public string units { get; set; }
    }
}
