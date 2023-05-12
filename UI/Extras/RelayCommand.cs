using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UI.Extras
{
    public class RelayCommand : ICommand
    {
        private readonly Action _executeMethod;

        private readonly Func<bool> _canExecuteMethod;

        public RelayCommand(Action ExecuteMethod, Func<bool> CanExecuteMethod = null)
        {
            this._executeMethod = ExecuteMethod;
            this._canExecuteMethod = CanExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;}
            remove { CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteMethod == null || _canExecuteMethod();
        }

        public void Execute(object parameter)
        {
            _executeMethod();
        }
    }
}
