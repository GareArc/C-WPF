using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace MVVM
{
    class ItemListViewModel : ViewModelbase

    {
        public ItemListViewModel() { }

        #region GetInstance
        private static ItemListViewModel _Instance = null;
        public static ItemListViewModel GetInstance()
        {
            if (_Instance == null) _Instance = new ItemListViewModel();
            return _Instance;
        }

        #endregion

        #region SharedPart
        private static ObservableCollection<Item> _SharedList = new ObservableCollection<Item>();
        public ObservableCollection<Item> SharedList
        {
            get { return _SharedList; }
            set { _SharedList = value; }
        }

        public void AddToSharedList(Item i) { SharedList.Add(i); }

        public void DeleteInSharedList(int index) { if (index >= 0) SharedList.RemoveAt(index); }

        #endregion

        #region ItemList1
        private ObservableCollection<Item> _ItemList1 = new ObservableCollection<Item>();
        public ObservableCollection<Item> ItemList1
        {
            get { return _ItemList1; }
            set { _ItemList1 = value; }
        }

        private double _ItemList1Count = 0;
        public double ItemList1Count
        {
            get { return _ItemList1Count; }
            set { _ItemList1Count = value; }
        }

        private double _Taxed1Count = 0;
        public double Taxed1Count
        {
            get { return _Taxed1Count; }
            set { _Taxed1Count = value; }
        }

        public void AddToList1(Item i) {
            double a = ItemList1Count;
            double b = Taxed1Count;
            AddToListHelper(ItemList1, i, ref a, ref b);
            ItemList1Count = a;
            Taxed1Count = b;
            //OnPropertyChanged("ItemList1Count");
            //MessageBox.Show(ItemList1Count.ToString());
        }
        public void DeleteInList1(int index) {
            double a = ItemList1Count;
            double b = Taxed1Count;
            DeleteInListHelper(ItemList1, index, ref a, ref b);
            ItemList1Count = a;
            Taxed1Count = b;
        }
        #endregion

        #region ItemList2
        private ObservableCollection<Item> _ItemList2 = new ObservableCollection<Item>();
        public ObservableCollection<Item> ItemList2
        {
            get { return _ItemList2; }
            set { _ItemList2 = value; }
        }

        private double _ItemList2Count = 0;

        public double ItemList2Count
        {
            get { return _ItemList2Count; }
            set { _ItemList2Count = value; }
        }

        private double _Taxed2Count = 0;

        public double Taxed2Count
        {
            get { return _Taxed2Count; }
            set { _Taxed2Count = value; }
        }

        public void AddToList2(Item i)
        {
            double a = ItemList2Count;
            double b = Taxed2Count;
            AddToListHelper(ItemList2, i, ref a, ref b);
            ItemList2Count = a;
            Taxed2Count = b;
        }
        public void DeleteInList2(int index)
        {
            double a = ItemList2Count;
            double b = Taxed2Count;
            DeleteInListHelper(ItemList2, index, ref a, ref b);
            ItemList2Count = a;
            Taxed2Count = b;
        }

        #endregion

        #region TwoPeopleTotalList
        private ObservableCollection<ItemShared> _TwoPeopleTotalList = new ObservableCollection<ItemShared>();
        public ObservableCollection<ItemShared> TwoPeopleTotalList
        {
            get { return _TwoPeopleTotalList; }
            set { _TwoPeopleTotalList = value; }
        }
        public void AddToTwoPeopleTotalList(ItemShared i)
        {
            TwoPeopleTotalList.Add(i);
        }

        public void DeleteFromTwoPeopleTotalList(int index)
        {
            if(index >= 0) TwoPeopleTotalList.RemoveAt(index);
        }

        #endregion

        #region General
        public void ClearLists()
        {
            SharedList = new ObservableCollection<Item>();
            ItemList1 = new ObservableCollection<Item>();
            ItemList2 = new ObservableCollection<Item>();
            TwoPeopleTotalList = new ObservableCollection<ItemShared>();
        }
        #endregion

        #region NormalCalculator
        public double CalculateSharedListTotal()
        {
            return CalculateListHelper(SharedList);
        }

        public double CalculateItemList1()
        {
            return CalculateListHelper(ItemList1);
        }

        public double CalculateItemList2()
        {
            return CalculateListHelper(ItemList2);
        }




        #endregion

        #region TwoPeopleListCalculator
        public double TwoPeopleCalculateForTarget1() 
        {
            double result = 0;
            foreach (var item in TwoPeopleTotalList) 
            {
                if (item.RelationId != 1) result += item.Calculate();
            }
            return result;
        }

        public double TwoPeopleCalculateForTarget2()
        {
            double result = 0;
            foreach (var item in TwoPeopleTotalList)
            {
                if (item.RelationId != 0) result += item.Calculate();
            }
            return result;
        }
        #endregion

        #region Helper
        private void AddToListHelper(ObservableCollection<Item> ItemList, Item i, ref double QCount, ref double TCount) 
        {
            ItemList.Add(i);
            QCount += i.Quantity;
            if (i.Taxed)
            {
                TCount += i.Quantity;
            }
        }

        private void DeleteInListHelper(ObservableCollection<Item> ItemList, int index, ref double QCount, ref double TCount) 
        {
            if (index < 0) return;
            var i = ItemList[index];
            QCount -= i.Quantity;
            if (i.Taxed) TCount -= i.Quantity;
            ItemList.RemoveAt(index);
        }

        private double CalculateListHelper(ObservableCollection<Item> list) 
        {
            double result = 0;
            foreach (var item in list)
            {
                result += item.Calculate();
            }
            return result;
        }
        #endregion
    }
}
