using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    partial class GlobalVM : ViewModelBase
    {
        public GlobalVM() 
        {
            


        }

        #region GetInstance
        private static GlobalVM _instance;

        public static GlobalVM GetInstance() 
        {
            if (_instance == null) _instance = new GlobalVM();
            return _instance;
        }
        #endregion
    }
}
