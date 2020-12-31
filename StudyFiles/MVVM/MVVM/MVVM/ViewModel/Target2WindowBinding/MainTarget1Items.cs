using MVVM.View;
using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class MainTarget2Items : ViewModelbase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ItemListsManager ItemLM { get; set; } = ItemListsManager.GetInstance();
        public UserManager um { get; set; } = UserManager.GetInstance();
        private IWindowFactory WindowFactory = new WindowFactory();
        public Action CloseTarget2Window { get; set; }
        public MainTarget2Items() 
        {
            // Add Nofification functions here.
            ItemLM.PropertyChanged += ItemListManagerPropertyChanged;

            // Initialize Commands.
            AddButtonCmd = new UnconditionalCmd(OpenAddItemWindow);
            DeleteButtonCmd = new ConditionalCmd(DeleteItemInList, CanDelete);
            ComfirmButtonCmd = new UnconditionalCmd(CloseWindow);
        }

    }
}
