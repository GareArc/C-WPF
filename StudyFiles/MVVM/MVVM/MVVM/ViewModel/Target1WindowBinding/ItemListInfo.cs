using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class MainTarget1Items
    {
        private int _SelectedIndex = -1;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { _SelectedIndex = value; }
        }
    }
}
