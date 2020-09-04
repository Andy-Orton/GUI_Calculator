using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DateCalcWPF.Commands
{
    public class CalculateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            
        }

        public CalculateCommand(Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

    }
}
