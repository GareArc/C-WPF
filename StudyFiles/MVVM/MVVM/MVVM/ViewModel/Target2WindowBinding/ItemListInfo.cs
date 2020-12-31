using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    partial class MainTarget2Items
    {
        private int _SelectedIndex = -1;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { _SelectedIndex = value; }
        }

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
            if (e.PropertyName == "ItemList2") RaisePropertyChanged("ItemList2");
            if (e.PropertyName == "ItemList2Count") RaisePropertyChanged("ItemList2Count");
            if (e.PropertyName == "Taxed2Count") RaisePropertyChanged("Taxed2Count");
        }
    }
}
