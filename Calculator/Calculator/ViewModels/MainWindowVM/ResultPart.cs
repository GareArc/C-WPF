
using System;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    partial class MainWindowVM
    {
        #region UserResults
        public string User1Result { get; set; } = "";
        public string User2Result { get; set; } = "";
        #endregion

        #region Calculate Button
        public ICommand CalculateBtnCmd { get { return new ConditionalCmd(Calculate, CanCalculate); } }

        private bool CanCalculate(object parameter)
        {
            try
            {
                double.Parse(DF);
                double.Parse(WF);
                double.Parse(AMZ);
                double.Parse(AMZP);
                double.Parse(WM);
                double.Parse(QT);
            }
            catch (Exception e) { return false; }
            return true;
        }

        private void Calculate(object paramater)
        {
            double three = 0;
            double user1 = 0;
            double user2 = 0;

            // three people
            three += double.Parse(DF);
            three += double.Parse(WF);
            three += double.Parse(AMZ);
            three += double.Parse(AMZP);
            three += double.Parse(WM);
            three += double.Parse(QT);

            three += globalVM.CalculateForSharedList();

            three += globalVM.CalculateAllTipsAndOther();
            

            // user 1
            user1 = globalVM.CalculateForTarget1ListTotal() + (three / 3);

            // user 2
            user2 = globalVM.CalculateForTarget2ListTotal() + (three / 3);

            // change binding variables
            User1Result = string.Format("{0} 总计: {1}", globalVM.Target1, Math.Round(user1, 3));
            User2Result = string.Format("{0} 总计: {1}", globalVM.Target2, Math.Round(user2, 3));
        }
        #endregion

        #region Clear Button
        public ICommand ClearBtnCmd { get { return new UnconditionalCmd(Clear); } }

        private void Clear(object parameter) 
        {
            globalVM.ClearLists();
            windowF.ResetAllWindows();

            windowF.OpenMainWindow();
            CloseWindow();
        }
        #endregion

        #region Export Button
        public ICommand ExportBtnCmd { get { return new ConditionalCmd(Export, CanExport); } }

        private bool CanExport(object parameter) 
        {
            return User1Result != "" && User2Result != ""; 
        }

        private void Export(object parameter) 
        {
            PrintGateway.Print();
        }
        #endregion


    }
}
