
using MVVM.View;
using System;

namespace MVVM
{
    partial class MainWindowItems : ViewModelbase
    {
        private IWindowFactory _WindowFactory = new WindowFactory();
        private ItemListsManager _ItemListsM = ItemListsManager.GetInstance();
        private UserManager _um = UserManager.GetInstance();
        private PrintManager _pm;
        public Action CloseMainWindow { get; set; }

        public MainWindowItems() 
        {
            // Initialize 
            Target1Result = string.Format("目标一待定");
            Target2Result = string.Format("目标二待定");
            pm = new PrintManager(this);
            // Inner Notification
            um.PropertyChanged += UserMangerPropertyChanged;
        }

        public ItemListsManager ItemListsM { get { return _ItemListsM; } }
        public UserManager um { get { return _um; } }
        public PrintManager pm { get { return _pm; } set { _pm = value; } }
    }
}
