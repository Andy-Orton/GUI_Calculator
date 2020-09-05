using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalcWPF.Model
{
    public class CalculatorInput
    {
        public CalculatorInput(string firstDate, string secondDate, string units, double output)
        {
            this.secondDateTime = secondDate;
            this.units = units;
            this.output = output;
            this.firstDateTime = firstDate;
        }

        public string firstDateTime { get; set; }
        public string secondDateTime { get; set; }
        public string units { get; set; }
        public double output { get; set; }
    }
}
