using System.Windows.Input;
using System;

namespace MVVM
{
    partial class MainTwoPeopleItems
    {
        # region AddButton
        public ICommand AddButtonCmd { get { return new UnconditionalCmd(OpenAddItemWindow); } }

        private void OpenAddItemWindow(object parameter)
        {
            WindowFactory.OpenAddItem2Window(SelectedIndex, ChoiceList[SelectedIndex]);
        }
        #endregion

        #region DeleteButton
        public ICommand DeleteBtnCmd { get { return new ConditionalCmd(DeleteItem, CanDeleteItem); } }

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
        public ICommand ConfirmButtonCmd { get { return new UnconditionalCmd(CloseWindow); } }

        private void CloseWindow(object parameter) 
        {
            CloseMainTwoPeopleWindow();
        }
        #endregion
    }
}
