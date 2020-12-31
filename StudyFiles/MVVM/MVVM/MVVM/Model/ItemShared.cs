using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class ItemShared : Item
    {
        public ItemShared(double Price, double Quantity, bool Taxed, int RelationId, string Relation) : base(Price, Quantity, Taxed)
        {
            this.Relation = Relation;
            this.RelationId = RelationId;
        }

        private int _RelationId;
        public int RelationId 
        {
            get { return _RelationId; }
            set { _RelationId = value; }
        }

        private string _Relation;
        public string Relation 
        {
            get { return _Relation; }
            set { _Relation = value; } 
        }

        public override string ToString()
        {
            return string.Format("${0} * {1}  {2} [{3}]", Price, Quantity, Taxed ? "(Taxed)" : "", Relation);
        }
    }
}
