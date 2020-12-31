using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MVVM.View
{
    class WindowFactory : IWindowFactory
    {
        public WindowFactory() { }
        /// <summary>
        /// Open a normal window. 
        /// 0:Main, 
        /// 1:Target1, 
        /// 2:Target2.
        /// 3:TwoPeople
        /// </summary>
        public void OpenNormalWindow(int a, bool IsDependent = true)
        {
            Window w = null;
            switch (a) 
            {
                case 0:
                    w = new MainWindow();
                    break;
                case 1:
                    w = new Target1Window();
                    break;
                case 2:
                    w = new Target2Window();
                    break;
                case 3:
                    w = new TwoPeopleWindow();
                    break;

            }
            OpenSubWindow(w, IsDependent);
        }

        /// <summary>
        /// Open an AddItem1 window. 
        /// [arg] 0: Shared 1: List1 2: List2
        /// </summary>
        public void OpenAddItem1Window(int arg, bool IsDependent = true) 
        {
            Window w = new AddItemWindow(arg);
            OpenSubWindow(w, IsDependent);
            
        }

        /// <summary>
        /// Open an AddItem2 window. 
        /// </summary>
        public void OpenAddItem2Window(int rid, string r, bool IsDependent = true) 
        {
            Window w = new AddItem2Window(rid, r);
            OpenSubWindow(w, IsDependent);
        }

        private void OpenSubWindow(Window w, bool IsDependent) 
        {
            if (w == null) return;
            if (IsDependent) w.ShowDialog();
            else w.Show();

        }
    }
}
