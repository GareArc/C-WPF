using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    internal class Item
    {
        public Item(double Price, double Quantity, bool Taxed) 
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.Taxed = Taxed;
        }

        public override string ToString()
        {
            return string.Format("${0} * {1}  {2}", Price, Quantity, Taxed ? "(Taxed)" : "");
        }

        private double _Price;
        public double Price 
        {
            get 
            {
                return _Price;
            }
            set 
            {
                this._Price = value;
            }
        }

        private double _Quantity;
        public double Quantity 
        {
            get 
            {
                return _Quantity;
            }
            set
            {
                this._Quantity = value;
            }
        }

        private bool _Taxed;
        public bool Taxed 
        {
            get 
            {
                return _Taxed;    
            }
            set
            {
                this._Taxed = value;
            }
        }

        public double Calculate() 
        {
            double result = 0;
            result += Price * Quantity;
            if (Taxed) result *= 1.13;
            return result;
        }
    }
}
