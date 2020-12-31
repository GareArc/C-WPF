
namespace MVVM
{
    partial class MainAddItem2Items
    {
        private string _Price;
        private string _Quantity;
        private bool _Taxed = false;

        public string PriceText
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

        public string QuantityText
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
        public bool TaxedText
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

    }
}
