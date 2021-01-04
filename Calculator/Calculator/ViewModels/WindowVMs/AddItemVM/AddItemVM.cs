using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    partial class AddItemVM : ViewModelBase
    {
        public GlobalVM globalVM { get; set; } = GlobalVM.GetInstance();
        public Action CloseWindow { get; set; }
        public AddItemVM() 
        {
            
        }
    }
}
