using MVVM.View;
using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class Target1ViewModel : ViewModelbase
    {
        public ItemListViewModel _ItemLM = ItemListViewModel.GetInstance();
        public UserViewModel _um = UserViewModel.GetInstance();
        private IWindowFactory _WindowFactory = new WindowFactory();
        private Action _CloseWindow;
        public Target1ViewModel(Action c) 
        {
            // Initialize CloseWindow Action
            _CloseWindow = c;
        }

        public UserViewModel um { get { return _um; } }
        public ItemListViewModel ItemLM { get { return _ItemLM; } }

    }
}
