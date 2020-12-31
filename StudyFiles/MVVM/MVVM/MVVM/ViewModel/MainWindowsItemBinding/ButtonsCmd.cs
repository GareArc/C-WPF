using System.Windows.Input;
using System.Windows.Media;
using System;
using System.Windows;

namespace MVVM
{
    partial class MainWindowItems
    {
        #region AddItemButtonCmd
        public ICommand AddItemButtonCmd { get; set; }
        private void OpenAddItemWindow(object parameter)
        {
            WindowFactory.OpenAddItem1Window(0);
        }
        #endregion

        #region CalculateFinalCmd
        public ICommand CalculateFinalCmd { get; set; }
        private bool CanCalculateFinal(object parameter)
        {
            double a;
            if (!DfC && !double.TryParse(Df, out a)) return false;
            if (!WfC && !double.TryParse(Wf, out a)) return false;
            if (!AmzC && !double.TryParse(Amz, out a)) return false;
            if (!AmzpC && !double.TryParse(Amzp, out a)) return false;
            if (!WmC && !double.TryParse(Wm, out a)) return false;
            if (!QtC && !double.TryParse(Qt, out a)) return false;
            return true;
        }

        private void CalculateFinal(object parameter)
        {
            double target1 = 0;
            double target2 = 0;
            double shared = 0;

            // Shared part
            if (!DfC) shared += double.Parse(Df);
            if (!WfC) shared += double.Parse(Wf);
            if (!AmzC) shared += double.Parse(Amz);
            if (!AmzpC) shared += double.Parse(Amzp);
            if (!WmC) shared += double.Parse(Wm);
            if (!QtC) shared += double.Parse(Qt);

            shared += ItemListsM.CalculateSharedListTotal();

            shared /= 3;

            // Target 1
            target1 += ItemListsM.CalculateItemList1();
            target1 += ItemListsM.TwoPeopleCalculateForTarget1() / 2;

            // Target 2
            target2 += ItemListsM.CalculateItemList2();
            target2 += ItemListsM.TwoPeopleCalculateForTarget2() / 2;

            // Count in Shared part
            target1 += shared;
            target2 += shared;

            // Assign value
            Target1Total = Math.Round(target1, 3);
            Target2Total = Math.Round(target2, 3);
            ChangeTargetResults();
        }

        private void ChangeTargetResults()
        {
            Target1Result = string.Format("{0}总计: {1}", Target1User, Target1Total);
            Target2Result = string.Format("{0}总计: {1}", Target2User, Target2Total);
            RaisePropertyChanged("Target2Result");
            RaisePropertyChanged("Target1Result");
        }
        #endregion

        #region DeleteItemButtonCmd
        public ICommand DeleteItemButtonCmd { get; set; }

        private bool CanDeleteItemFromSharedList(object parameter)
        {
            return SeletedIndex >= 0;
        }
        private void DeleteItemFromSharedList(object parameter)
        {
            ItemListsM.DeleteInSharedList(SeletedIndex);
        }
        #endregion

        #region Edit1Cmd
        public ICommand Edit1Cmd { get; set; }
        private void OpenTarget1Window(object parameter)
        {
            WindowFactory.OpenNormalWindow(1);
        }
        #endregion

        #region ResetButtonCmd
        public ICommand ResetButtonCmd { get; set; }
        private void ResetAll(object parameter)
        {
            ItemListsM.ClearLists();
            WindowFactory.OpenNormalWindow(0);
            CloseMainWindow();
        }
        #endregion

        #region Edit2Cmd
        public ICommand Edit2Cmd { get; set; }
        private void OpenTarget2Window(object parameter)
        {
            WindowFactory.OpenNormalWindow(2);
        }
        #endregion

        #region Edit3Cmd
        public ICommand Edit3Cmd { get; set; }
        private void OpenTwoPeopleWindow(object parameter)
        {
            WindowFactory.OpenNormalWindow(3);
        }
        #endregion

        #region PrintInfoBtnCmd
        public ICommand PrintInfoBtnCommand { get; set; }

        private void PrintInfo(object parameter) 
        {
            pm.Print();
        }
        #endregion
    }
}
