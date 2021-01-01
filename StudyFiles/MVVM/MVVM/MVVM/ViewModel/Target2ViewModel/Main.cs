using MVVM.View;
using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class Target2ViewModel : ViewModelbase
    {
        private ItemListViewModel _ItemLM = ItemListViewModel.GetInstance();
        private UserViewModel _um= UserViewModel.GetInstance();
        private IWindowFactory _WindowFactory = new WindowFactory();
        public Action CloseTarget2Window { get; set; }
        public Target2ViewModel() 
        {
        }

        public UserViewModel um { get { return _um; } }
        public ItemListViewModel ItemLM { get { return _ItemLM; } }

    }
}
