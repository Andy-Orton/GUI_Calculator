using DateCalcWPF.Model;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DateCalcWPF
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Title = "Date Calculator";
        }

        private string title;
        public string Title
        {
            get => title;
            set { SetProperty(ref title, value); }
        }
    }
}
