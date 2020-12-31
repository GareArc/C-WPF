using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace MVVM
{
    partial class MainTarget1Items
    {
        public ICommand AddButtonCmd { get; set; }
        public ICommand DeleteButtonCmd { get; set; }

        public ICommand ComfirmButtonCmd { get; set; }

        private void OpenAddItemWindow(object parameter) 
        {
            WindowFactory.OpenAddItem1Window(1);
        }

        private bool CanDelete(object parameter) 
        {
            return SelectedIndex >= 0;
        }

        private void DeleteItemInList(object parameter) 
        {
            ItemLM.DeleteInList1(SelectedIndex);
        }

        private void CloseWindow(object parameter) 
        {
            _CloseWindow();
        }
    }
}
