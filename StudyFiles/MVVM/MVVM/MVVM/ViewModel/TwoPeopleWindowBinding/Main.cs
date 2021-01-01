using MVVM.View;
using System;
using System.Collections.Generic;

namespace MVVM
{
    partial class MainTwoPeopleItems : ViewModelbase
    {
        #region Private properties
        private ItemListsManager _ItemLM = ItemListsManager.GetInstance();
        private UserManager _um = UserManager.GetInstance();
        public Action CloseMainTwoPeopleWindow;
        private IWindowFactory WindowFactory = new WindowFactory();
        #endregion

        #region Public properties
        public ItemListsManager ItemLM { get { return _ItemLM; } }
        public UserManager um { get { return _um; } }
        #endregion

        public MainTwoPeopleItems() 
        {
            // Inner notification

            // Initialize ChoiceList
            ChoiceList.Add("我和" + um.Target1User);
            ChoiceList.Add("我和" + um.Target2User);
            ChoiceList.Add(um.Target1User + "和" + um.Target2User);
        }
    }
}
