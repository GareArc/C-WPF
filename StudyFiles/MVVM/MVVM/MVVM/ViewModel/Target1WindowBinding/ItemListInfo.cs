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


        #region ItemList1 info form ItemListsManager
        public ObservableCollection<Item> ItemList1
        {
            get { return ItemLM.ItemList1; }
            set { ItemLM.ItemList1 = value; }
        }
        public double ItemList1Count
        {
            get { return ItemLM.ItemList1Count; }
            set { ItemLM.ItemList1Count = value; }
        }
        public double Taxed1Count
        {
            get { return ItemLM.Taxed1Count; }
            set { ItemLM.Taxed1Count = value; }
        }

        #endregion

        #region ItemList2 info from ItemListsManger
        public ObservableCollection<Item> ItemList2
        {
            get { return ItemLM.ItemList2; }
            set { ItemLM.ItemList2 = value; }
        }

        public double ItemList2Count
        {
            get { return ItemLM.ItemList2Count; }
            set { ItemLM.ItemList2Count = value; }
        }

        public double Taxed2Count
        {
            get { return ItemLM.Taxed2Count; }
            set { ItemLM.Taxed2Count = value; }
        }
        #endregion


        private void ItemListManagerPropertyChanged(object sender, PropertyChangedEventArgs e) 
        {
            if (e.PropertyName == "ItemList1") RaisePropertyChanged("ItemList1");
            if (e.PropertyName == "ItemList1Count") RaisePropertyChanged("ItemList1Count");
            if (e.PropertyName == "Taxed1Count") RaisePropertyChanged("Taxed1Count");
        }
    }
}
