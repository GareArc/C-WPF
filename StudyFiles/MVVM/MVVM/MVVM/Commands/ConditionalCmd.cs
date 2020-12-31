using System;
using System.Windows.Input;

namespace MVVM
{
    class ConditionalCmd : ICommand
    {
        Action<object> _executeMethod;
        Func<object, bool> _canExecuteMethod;
        public ConditionalCmd(Action<object> ExecuteMethod, Func<object, bool> CanExecuteMethod)
        {
            _executeMethod = ExecuteMethod;
            _canExecuteMethod = CanExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteMethod == null) return false;
            else return _canExecuteMethod(parameter);
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}
