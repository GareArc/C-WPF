using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVM
{
    internal class Item
    {
        public Item(double Price, double Quantity, bool Taxed, ItemType.ShopTypes type) 
        {
            this.Price = Price;
            this.Quantity = Quantity;
            this.Taxed = Taxed;
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("[{0}] ${1} * {2}  {3}", Type , Price, Quantity, Taxed ? "(Taxed)" : "");
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

        private ItemType.ShopTypes _Type;
        public ItemType.ShopTypes Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public double Calculate() 
        {
            double result = 0;
            double net = Price * Quantity;
            result += net * GetWeight(Type);
            if (Taxed) result += net * 0.13;
            return result + net;
        }

        private double GetWeight(ItemType.ShopTypes type) 
        {
            switch (type) 
            {
                case ItemType.ShopTypes.JingniuCheng:
                    return 0.05;
                case ItemType.ShopTypes.UberEats:
                    return 0.11308;
                default:
                    return 0;
            } 
        }
    }
}
