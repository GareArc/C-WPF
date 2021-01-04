
using System.Collections.Generic;

namespace Calculator
{
    partial class MainWindowVM
    {
        #region Combox
        public List<Users> ChoiceList_Users { get;} = new List<Users>
        {
            Users.Charlie,
            Users.Gareth,
            Users.Ethan,
            Users.Unknown,
        };
        #endregion
    }
}
