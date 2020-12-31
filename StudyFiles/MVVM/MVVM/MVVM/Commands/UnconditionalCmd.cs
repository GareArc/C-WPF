using System;
using System.Windows.Input;

namespace MVVM
{
    class UnconditionalCmd : ICommand
    {
        Action<object> _executeMethod;
        public UnconditionalCmd(Action<object> ExecuteMethod)
        {
            _executeMethod = ExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}
