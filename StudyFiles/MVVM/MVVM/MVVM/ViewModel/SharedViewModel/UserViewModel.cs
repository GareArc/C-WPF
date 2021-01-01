using System.Collections.Generic;
using System.ComponentModel;

namespace MVVM
{
    class UserViewModel : ViewModelbase
    {
        public UserViewModel() { }


        private static UserViewModel _Instance = null;
        public static UserViewModel GetInstance() 
        {
            if (_Instance == null) _Instance = new UserViewModel();
            return _Instance;
        }

        
        private User.UsersTypes _Target1User = User.UsersTypes.Unknown;
        private User.UsersTypes _Target2User = User.UsersTypes.Unknown;
        private List<User.UsersTypes> _SelectionBox =
            new List<User.UsersTypes> { User.UsersTypes.Charlie, User.UsersTypes.Ethan, User.UsersTypes.Gareth, User.UsersTypes.Unknown };
        public User.UsersTypes Target1User
        {
            get { return _Target1User; }
            set { _Target1User = value;}
        }

        public User.UsersTypes Target2User
        {
            get { return _Target2User; }
            set { _Target2User = value; }
        }

        public List<User.UsersTypes> SelectionBox 
        {
            get { return _SelectionBox; }
        }
    }
}
