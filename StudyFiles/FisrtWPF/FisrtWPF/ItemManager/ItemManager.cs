using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisrtWPF
{
    class ItemManager : INotifyPropertyChanged 
    {
        private static ObservableCollection<Item> Shared { get; set; } = new ObservableCollection<Item>();
        private static ObservableCollection<Item> Items1 { get; set; } = new ObservableCollection<Item>();
        private static ObservableCollection<Item> Items2 { get; set; } = new ObservableCollection<Item>();

        private static Item LastItem { get; set; }

        private static bool Updated { get; set; } = false;

        public ItemManager() {}

        public ObservableCollection<Item> GetShared() { return Shared; }
        public ObservableCollection<Item> GetItems1() { return Items1; }

        public ObservableCollection<Item> GetItems2() { return Items2; }

        public void RemoveFromShared(int index) { if(index >= 0) Shared.RemoveAt(index); }
        public void RemoveFromItems1(int index) { if (index >= 0) Items1.RemoveAt(index); }
        public void RemoveFromItems2(int index) { if (index >= 0) Items2.RemoveAt(index); }


        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public void ClearAll() 
        {
            Items1 = new ObservableCollection<Item>();
            Items2 = new ObservableCollection<Item>();
            Shared = new ObservableCollection<Item>();
            LastItem = null;
            Updated = false;
        }

        public void FinishUpdate() 
        {
            Updated = false;
        }

        public bool GetUpdateInfo() { return Updated; }

        public bool AddToSharedList(string price, string quantity, bool? taxed) 
        {
            Item NewItem = AddToListHelper(price, quantity, taxed);
            if (NewItem == null) return false;
            Shared.Add(NewItem);
            return true;

        }
        public bool AddToList1(string price, string quantity, bool? taxed) 
        {
            Item NewItem = AddToListHelper(price, quantity, taxed);
            if (NewItem == null) return false;
            Items1.Add(NewItem);
            return true;
        }

        public bool AddToList2(string price, string quantity, bool? taxed)
        {
            Item NewItem = AddToListHelper(price, quantity, taxed);
            if (NewItem == null) return false;
            Items2.Add(NewItem);
            return true;
        }

        private Item AddToListHelper(string price, string quantity, bool? taxed) 
        {
            bool istaxed;
            if (taxed.HasValue) istaxed = (bool)taxed;
            else istaxed = false;

            //parse string to double
            double p, q;
            if (!double.TryParse(price, out p)) return null;
            if (!double.TryParse(quantity, out q)) return null;

            Item item = new Item(0, p, q, istaxed);
            LastItem = item;
            Updated = true;
            return item;
        }

        public double CalculatePriceIn1() 
        {
            double result = 0;
            foreach (var item in Items1)
            {
                result += item.CalculatePrice();
            }
            return result;
        }

        public double CalculatePriceIn2()
        {
            double result = 0;
            foreach (var item in Items2)
            {
                result += item.CalculatePrice();
            }
            return result;
        }

        public double CalculatePriceShared()
        {
            double result = 0;
            foreach (var item in Shared) 
            {
                result += item.CalculatePrice();
            }
            return result;
        }

        public string GetLastItemInfo()
        {
            return LastItem.ToString();
        }

    }
}
