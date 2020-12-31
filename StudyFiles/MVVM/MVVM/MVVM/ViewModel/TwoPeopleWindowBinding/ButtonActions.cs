using System.Windows.Input;
using System;

namespace MVVM
{
    partial class MainTwoPeopleItems
    {
        # region AddButton
        public ICommand AddButtonCmd { get; set; }

        private void OpenAddItemWindow(object parameter)
        {
            WindowFactory.OpenAddItem2Window(SelectionIndex, ChoiceList[SelectionIndex]);
        }
        #endregion

        #region DeleteButton
        public ICommand DeleteBtnCmd { get; set; }

        private void DeleteItem(object parameter) 
        {
            ItemLM.DeleteFromTwoPeopleTotalList(ViewListSelectionIndex);
        }

        private bool CanDeleteItem(object parameter) 
        {
            return ViewListSelectionIndex >= 0;
        }
        #endregion

        #region ConfirmButton
        public ICommand ConfirmButtonCmd { get; set; }

        private void CloseWindow(object parameter) 
        {
            CloseMainTwoPeopleWindow();
        }
        #endregion
    }
}
