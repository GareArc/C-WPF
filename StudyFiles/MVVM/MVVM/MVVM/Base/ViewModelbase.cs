
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    class ViewModelbase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string caller) 
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public void QuickPropertyChanged([CallerMemberName] string caller = "") 
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public void InnerPropertyChanged(PropertyChangedEventArgs e, string PropertyName) 
        {
            if (e.PropertyName == PropertyName) RaisePropertyChanged(PropertyName);        
        }

        public void InnerPropertyChanged(PropertyChangedEventArgs e, string PropertyName, string NotifyName)
        {
            if (e.PropertyName == PropertyName) RaisePropertyChanged(NotifyName);
        }
    }
}
