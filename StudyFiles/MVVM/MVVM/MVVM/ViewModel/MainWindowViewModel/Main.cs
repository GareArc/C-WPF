
using MVVM.View;
using System;

namespace MVVM
{
    partial class MainWindowViewModel : ViewModelbase
    {
        private IWindowFactory _WindowFactory = new WindowFactory();
        private ItemListViewModel _ItemListsM = ItemListViewModel.GetInstance();
        private UserViewModel _um = UserViewModel.GetInstance();
        private PrintManager _pm;
        public Action CloseMainWindow { get; set; }

        public MainWindowViewModel() 
        {
            // Initialize 
            Target1Result = string.Format("目标一待定");
            Target2Result = string.Format("目标二待定");
            pm = new PrintManager(this);
            // Inner Notification
            um.PropertyChanged += UserMangerPropertyChanged;
        }

        public ItemListViewModel ItemListsM { get { return _ItemListsM; } }
        public UserViewModel um { get { return _um; } }
        public PrintManager pm { get { return _pm; } set { _pm = value; } }
    }
}
