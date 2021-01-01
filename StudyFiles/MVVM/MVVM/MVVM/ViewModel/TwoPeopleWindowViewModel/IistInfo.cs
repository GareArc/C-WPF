using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    partial class TwoPeopleWindowViewModel
    {
        private int _SelectedIndex = 0;
        public int SelectedIndex{ get { return _SelectedIndex; } set { _SelectedIndex = value; } }

        private ObservableCollection<string> _ChoiceList = new ObservableCollection<string>();
        public ObservableCollection<string> ChoiceList { get { return _ChoiceList; } }

        private int _ViewListSelectionIndex = -1;
        public int ViewListSelectionIndex { get { return _ViewListSelectionIndex; } set { _ViewListSelectionIndex = value; } }
    }
}
