using DateCalcWPF.Calculator;
using DateCalcWPF.Model;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalcWPF.History
{
    public class HistoryViewModel : BindableBase
    {
        public List<CalculatorInput> calcInputs { get; set; }

        public HistoryViewModel()
        {

        }
    }
}
