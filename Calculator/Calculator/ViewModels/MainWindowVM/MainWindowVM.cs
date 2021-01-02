using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    partial class MainWindowVM : ViewModelBase
    {
        public GlobalVM globalVM { get; set; } = GlobalVM.GetInstance();
        private IWindowFactory windowF = WindowFactory.GetInstance();
        private Action CloseWindow;
        private PrintGateway PrintGateway;
        public MainWindowVM(Action a) 
        {
            PrintGateway = new PrintGateway(this);
            this.CloseWindow = a;
        }
    }
}
