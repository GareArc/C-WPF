using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string PropertyName) 
        {
            var temp = PropertyChanged;
            if (temp != null) PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public void QuickPropertyChanged([CallerMemberName] string caller = "") 
        {
            RaisePropertyChanged(caller);
        }

        public void InnerPropertyChanged(PropertyChangedEventArgs e, string innerName, string outerName) 
        {
            if (e.PropertyName == innerName) RaisePropertyChanged(outerName);
        }
    }
}
