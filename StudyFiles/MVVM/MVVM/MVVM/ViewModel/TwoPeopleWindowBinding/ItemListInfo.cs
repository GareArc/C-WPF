
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVM
{
    partial class MainTwoPeopleItems
    {
        #region Lists from ItemListManager
        public ObservableCollection<ItemShared> TwoPeopleTotalList
        {
            get { return ItemLM.TwoPeopleTotalList; }
            set { ItemLM.TwoPeopleTotalList = value; }
        }
        #endregion

        #region Selection Part
        private int _SelectionIndex = 0;
        public int SelectionIndex { get { return _SelectionIndex; } set { _SelectionIndex = value; } }

        private int _ViewListSelectionIndex = -1;
        public int ViewListSelectionIndex 
        {
            get { return _ViewListSelectionIndex; }
            set { _ViewListSelectionIndex = value; }
        }

        private ObservableCollection<string> _ChoiceList = new ObservableCollection<string>();
        public ObservableCollection<string> ChoiceList 
        {
            get { return _ChoiceList; }
            set { _ChoiceList = value; }
        }

        #endregion

        private void ItemListManagerPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            InnerPropertyChanged(e, "TwoPeopleTotalList");
        }
    }
}
