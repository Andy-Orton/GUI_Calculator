using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalcWPF.Model
{
    public class CalculatorInput
    {
        public DateTime firstDateTime { get; set; }
        public DateTime secondDateTime { get; set; }
        public string units { get; set; }
        public double output { get; set; }
    }
}
