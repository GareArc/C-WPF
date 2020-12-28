using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisrtWPF
{
    class ItemManager
    {
        private static List<Item> Items1 { get; set; } = new List<Item>();
        private static List<Item> Items2 { get; set; } = new List<Item>();

        private static Item LastItem { get; set; }

        public ItemManager() {}

        public bool AddToList1(string price, string quantity, bool? taxed) 
        {
            bool istaxed;
            if (taxed.HasValue) istaxed = (bool)taxed;
            else istaxed = false;

            //parse string to double
            double p, q;
            if (!double.TryParse(price, out p)) return false;
            if (!double.TryParse(quantity, out q)) return false;

            Item item = new Item(0, p, q, istaxed);
            Items1.Add(item);
            LastItem = item;

            return true;
        }

        public bool AddToList2(string price, string quantity, bool? taxed)
        {
            bool istaxed;
            if (taxed.HasValue) istaxed = (bool)taxed;
            else istaxed = false;

            //parse string to double
            double p, q;
            if (!double.TryParse(price, out p)) return false;
            if (!double.TryParse(quantity, out q)) return false;

            Item item = new Item(0, p, q, istaxed);
            Items2.Add(item);
            LastItem = item;

            return true;
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

        public string GetLastItemInfo()
        {
            return LastItem.ToString();
        }

    }
}
