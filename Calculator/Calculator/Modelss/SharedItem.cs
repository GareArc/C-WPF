using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SharedItem : BasicItem, ShoppingItem
    {
        public SharedItem(double Price, double Quantity, bool IsTaxed, double Weight, 
            Relation RelationType, string Relation, string ShopInfo) : base(Price,Quantity,IsTaxed,Weight, ShopInfo)
        {
            this.Relation = Relation;
            this.RelationType = RelationType;
        }

        public string Relation { get; set; }

        public Relation RelationType { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("[{0}]", Relation);
        }

        public override double Calculate()
        {
            return base.Calculate() / 2;
        }
    }
}
