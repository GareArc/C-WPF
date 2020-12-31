using MVVM.View;
using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class MainTarget1Items : ViewModelbase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ItemListsManager ItemLM { get; set; } = ItemListsManager.GetInstance();
        public UserManager um { get; set; } = UserManager.GetInstance();
        private IWindowFactory WindowFactory = new WindowFactory();
        private Action _CloseWindow;
        public MainTarget1Items(Action c) 
        {
            // Initialize CloseWindow Action
            _CloseWindow = c;
            // Add Nofification functions here.
            ItemLM.PropertyChanged += ItemListManagerPropertyChanged;

            // Initialize Commands.
            AddButtonCmd = new UnconditionalCmd(OpenAddItemWindow);
            DeleteButtonCmd = new ConditionalCmd(DeleteItemInList, CanDelete);
            ComfirmButtonCmd = new UnconditionalCmd(CloseWindow);
        }

    }
}
