using MVVM.View;
using System;
using System.Collections.Generic;

namespace MVVM
{
    partial class MainTwoPeopleItems : ViewModelbase
    {
        private ItemListsManager ItemLM = ItemListsManager.GetInstance();
        private UserManager um = UserManager.GetInstance();
        public Action CloseMainTwoPeopleWindow;

        private IWindowFactory WindowFactory = new WindowFactory();

        public MainTwoPeopleItems() 
        {
            // Inner notification
            ItemLM.PropertyChanged += ItemListManagerPropertyChanged;
            um.PropertyChanged += UserManagerPropertyChanged;
            // Initialize ChoiceList
            ChoiceList.Add("我和" + Target1User);
            ChoiceList.Add("我和" + Target2User);
            ChoiceList.Add(Target1User + "和" + Target2User);
            //Commands
            AddButtonCmd = new UnconditionalCmd(OpenAddItemWindow);
            DeleteBtnCmd = new ConditionalCmd(DeleteItem, CanDeleteItem);
            ConfirmButtonCmd = new UnconditionalCmd(CloseWindow);
        }
    }
}
