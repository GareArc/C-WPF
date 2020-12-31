
using MVVM.View;
using System;
using System.ComponentModel;

namespace MVVM
{
    partial class MainWindowItems : ViewModelbase
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IWindowFactory WindowFactory = new WindowFactory();
        public ItemListsManager ItemListsM = ItemListsManager.GetInstance();
        private UserManager um = UserManager.GetInstance();
        private PrintManager pm;
        public Action CloseMainWindow { get; set; }

        public MainWindowItems() 
        {
            // Initialize 
            Target1Result = string.Format("目标一待定");
            Target2Result = string.Format("目标二待定");
            pm = new PrintManager(this);
            // Inner Notification
            ItemListsM.PropertyChanged += ItemListManagerPropertyChanged;
            um.PropertyChanged += UserMangerPropertyChanged;
            // Commands
            dfCheck = new UnconditionalCmd(dfCheckExecute);
            wfCheck = new UnconditionalCmd(wfCheckExecute);
            amzCheck = new UnconditionalCmd(amzCheckExecute);
            amzpCheck = new UnconditionalCmd(amzpCheckExecute);
            wmCheck = new UnconditionalCmd(wmCheckExecute);
            qtCheck = new UnconditionalCmd(qtCheckExecute);
            AddItemButtonCmd = new UnconditionalCmd(OpenAddItemWindow);
            DeleteItemButtonCmd = new ConditionalCmd(DeleteItemFromSharedList, CanDeleteItemFromSharedList);
            Edit1Cmd = new UnconditionalCmd(OpenTarget1Window);
            ResetButtonCmd = new UnconditionalCmd(ResetAll);
            CalculateFinalCmd = new ConditionalCmd(CalculateFinal, CanCalculateFinal);
            Edit2Cmd = new UnconditionalCmd(OpenTarget2Window);
            Edit3Cmd = new UnconditionalCmd(OpenTwoPeopleWindow);
            PrintInfoBtnCommand = new UnconditionalCmd(PrintInfo);
        }
    }
}
