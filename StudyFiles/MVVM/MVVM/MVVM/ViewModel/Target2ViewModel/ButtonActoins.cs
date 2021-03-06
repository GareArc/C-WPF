﻿using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace MVVM
{
    partial class Target2ViewModel
    {
        public ICommand AddButtonCmd { get { return new UnconditionalCmd(OpenAddItemWindow); } }
        public ICommand DeleteButtonCmd { get { return new ConditionalCmd(DeleteItemInList, CanDelete); } }

        public ICommand ComfirmButtonCmd { get { return new UnconditionalCmd(CloseWindow); } }

        private void OpenAddItemWindow(object parameter) 
        {
            _WindowFactory.OpenAddItem1Window(2);
        }

        private bool CanDelete(object parameter) 
        {
            return SelectedIndex >= 0;
        }

        private void DeleteItemInList(object parameter) 
        {
            _ItemLM.DeleteInList2(SelectedIndex);
        }

        private void CloseWindow(object parameter) 
        {
            CloseTarget2Window();
        }
    }
}
