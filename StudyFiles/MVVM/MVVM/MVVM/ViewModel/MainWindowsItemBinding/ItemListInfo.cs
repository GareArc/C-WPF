using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace MVVM
{
    partial class MainWindowItems
    {
        private int _SeletedIndex = -1;
        public int SeletedIndex { get { return _SeletedIndex; } set { _SeletedIndex = value; } }
    }
}
