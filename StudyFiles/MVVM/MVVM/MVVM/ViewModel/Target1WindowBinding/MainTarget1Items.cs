using MVVM.View;
using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class MainTarget1Items : ViewModelbase
    {
        public ItemListsManager _ItemLM = ItemListsManager.GetInstance();
        public UserManager _um = UserManager.GetInstance();
        private IWindowFactory _WindowFactory = new WindowFactory();
        private Action _CloseWindow;
        public MainTarget1Items(Action c) 
        {
            // Initialize CloseWindow Action
            _CloseWindow = c;
        }

        public UserManager um { get { return _um; } }
        public ItemListsManager ItemLM { get { return _ItemLM; } }

    }
}
