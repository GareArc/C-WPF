using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator
{
    class ConditionalCmd : ICommand
    {
        private Action<object> ExecuteMethod;
        private Func<object, bool> CanExecuteMethod;
        public ConditionalCmd(Action<object> Execute, Func<object, bool> Can) 
        {
            this.ExecuteMethod = Execute;
            this.CanExecuteMethod = Can;
        }

        public event EventHandler CanExecuteChanged 
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (CanExecuteMethod == null) return false;
            return CanExecuteMethod(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteMethod(parameter);
        }
    }
}
