

using System.ComponentModel;

namespace MVVM
{
    partial class MainTwoPeopleItems
    {
        #region Info from UserManager
        public User.UsersTypes Target1User 
        {
            get { return um.Target1User; }
        }
        public User.UsersTypes Target2User
        {
            get { return um.Target2User; }
        }
        #endregion

        private void UserManagerPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            InnerPropertyChanged(e, "Target1User", "ChoiceList");
            InnerPropertyChanged(e, "Target2User", "ChoiceList");
        }

    }
}
