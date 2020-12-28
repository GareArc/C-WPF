using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FisrtWPF
{
    public class Item : INotifyPropertyChanged
    {
        private int Target { get; }
        private double Price { get; set; }

        private double Quantity { get; set; }
        private bool IsTaxed { get; set; }

        public Item(int target, double price, double quantity, bool taxed)
        {
            this.Price = price;
            this.Target = target;
            this.Quantity = quantity;
            this.IsTaxed = taxed;
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};

        public double CalculatePrice()
        {
            // Calculate base price.
            double Rprice = this.Price *this.Quantity;
            if (this.IsTaxed) Rprice *= 1.13;
            return Rprice;
        }
        public override string ToString()
        {
            return string.Format("${0} * {1}  {2}", this.Price, this.Quantity, this.IsTaxed ? "(Taxed)" : "");
        }
    }
}
