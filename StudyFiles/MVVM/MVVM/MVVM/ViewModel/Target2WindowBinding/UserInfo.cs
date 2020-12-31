using System.ComponentModel;

namespace MVVM
{
    partial class MainTarget2Items
    {
        public User.UsersTypes Target2User
        {
            get { return um.Target2User; }
            set { um.Target2User = value; }
        }

        private void UserMangerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Target2User") RaisePropertyChanged("Target2User");
        }
    }
}
