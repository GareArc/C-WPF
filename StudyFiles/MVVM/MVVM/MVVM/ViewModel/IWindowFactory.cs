using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    interface IWindowFactory
    {
        /// <summary>
        /// Open a normal window. 
        /// 0:Main, 
        /// 1:Target1, 
        /// 2:Target2.
        /// 3:TwoPeople
        /// </summary>
        void OpenNormalWindow(int a, bool IsDependent = true);

        /// <summary>
        /// Open an AddItem1 window. 
        /// [arg] 0: Shared 1: List1 2: List2
        /// </summary>
        void OpenAddItem1Window(int arg, bool IsDependent = true);

        /// <summary>
        /// Open an AddItem2 window. 
        /// </summary>
        void OpenAddItem2Window(int rid, string r, bool IsDependent = true);
    }
}
