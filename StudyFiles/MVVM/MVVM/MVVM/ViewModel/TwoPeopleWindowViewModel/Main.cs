using MVVM.View;
using System;
using System.Collections.Generic;

namespace MVVM
{
    partial class TwoPeopleWindowViewModel : ViewModelbase
    {
        #region Private properties
        private ItemListViewModel _ItemLM = ItemListViewModel.GetInstance();
        private UserViewModel _um = UserViewModel.GetInstance();
        public Action CloseMainTwoPeopleWindow;
        private IWindowFactory WindowFactory = new WindowFactory();
        #endregion

        #region Public properties
        public ItemListViewModel ItemLM { get { return _ItemLM; } }
        public UserViewModel um { get { return _um; } }
        #endregion

        public TwoPeopleWindowViewModel() 
        {
            // Inner notification

            // Initialize ChoiceList
            ChoiceList.Add("我和" + um.Target1User);
            ChoiceList.Add("我和" + um.Target2User);
            ChoiceList.Add(um.Target1User + "和" + um.Target2User);
        }
    }
}
