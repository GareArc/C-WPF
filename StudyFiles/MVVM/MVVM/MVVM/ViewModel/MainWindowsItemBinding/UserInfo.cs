using System.Collections.Generic;
using System.ComponentModel;

namespace MVVM
{
    partial class MainWindowItems
    {

        public User.UsersTypes Target1User 
        {
            get { return um.Target1User; }
            set { um.Target1User = value; }
        }

        public User.UsersTypes Target2User
        {
            get { return um.Target2User; }
            set { um.Target2User = value; }
        }

        public List<User.UsersTypes> SelectionBox
        {
            get { return um.SelectionBox; }
        }

        private void UserMangerPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            if (e.PropertyName == "Target1User") 
            {
                Target1Result = string.Format("{0}总计: {1}", Target1User, Target1Total);
                RaisePropertyChanged("Target1User");
                RaisePropertyChanged("Target1Result");
            }

            if (e.PropertyName == "Target2User") 
            {
                Target2Result = string.Format("{0}总计: {1}", Target2User, Target2Total);
                RaisePropertyChanged("Target2User");
                RaisePropertyChanged("Target2Result");
            }

        }

    }
}
