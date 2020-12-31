using System.ComponentModel;

namespace MVVM
{
    partial class MainTarget1Items
    {
        public User.UsersTypes Target1User
        {
            get { return um.Target1User; }
            set { um.Target1User = value; }
        }

        private void UserMangerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Target1User") RaisePropertyChanged("Target1User");
        }
    }
}
