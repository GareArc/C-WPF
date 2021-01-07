using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BasicItem : ShoppingItem
    {
        public BasicItem(double Price, double Quantity, bool IsTaxed, double Weight, string ShopInfo) 
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.IsTaxed = IsTaxed;
            this.Weight = Weight;
            this.ShopInfo = ShopInfo;
        }

        public double Price { get; set; }
        public double Quantity { get; set; }
        public bool IsTaxed { get; set; }
        public double Weight { get; set; }
        public string ShopInfo { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}+{1:P2}]${2} * {3} {4}", ShopInfo, Weight, Price, Quantity, IsTaxed ? "(Taxed)" : "");
        }

        public virtual double Calculate()
        {
            double result = 0;
            double net = Price * Quantity;
            result = net * Weight;
            if (IsTaxed) result += net * GLOBAL.TAX;
            return result + net;
        }

    }
}
