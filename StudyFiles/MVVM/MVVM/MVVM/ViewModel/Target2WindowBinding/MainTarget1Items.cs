using MVVM.View;
using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class MainTarget2Items : ViewModelbase
    {
        private ItemListsManager _ItemLM = ItemListsManager.GetInstance();
        private UserManager _um= UserManager.GetInstance();
        private IWindowFactory _WindowFactory = new WindowFactory();
        public Action CloseTarget2Window { get; set; }
        public MainTarget2Items() 
        {
        }

        public UserManager um { get { return _um; } }
        public ItemListsManager ItemLM { get { return _ItemLM; } }

    }
}
