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

        #region SharedList info from ItemListsManager
        public ObservableCollection<Item> SharedList
        {
            get { return ItemListsM.SharedList; }
            set { ItemListsM.SharedList = value; }
        }

        #endregion

        #region ItemList1 info form ItemListsManager
        public ObservableCollection<Item> ItemList1
        {
            get { return ItemListsM.ItemList1; }
            set { ItemListsM.ItemList1 = value; }
        }
        public double ItemList1Count
        {
            get { return ItemListsM.ItemList1Count; }
            set { ItemListsM.ItemList1Count = value; }
        }
        public double Taxed1Count
        {
            get { return ItemListsM.Taxed1Count; }
            set { ItemListsM.Taxed1Count = value; }
        }

        #endregion

        #region ItemList2 info from ItemListsManger
        public ObservableCollection<Item> ItemList2
        {
            get { return ItemListsM.ItemList2; }
            set { ItemListsM.ItemList2 = value; }
        }

        public double ItemList2Count
        {
            get { return ItemListsM.ItemList2Count; }
            set { ItemListsM.ItemList2Count = value; }
        }

        public double Taxed2Count
        {
            get { return ItemListsM.Taxed2Count; }
            set { ItemListsM.Taxed2Count = value; }
        }
        #endregion

        private void ItemListManagerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SharedList") RaisePropertyChanged("SharedList");

        }

    }
}
