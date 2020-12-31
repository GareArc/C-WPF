using System.Windows.Input;
using System;

namespace MVVM
{
    partial class MainAddItem2Items
    {
        public ICommand ComfirmCmd { get; set; }
        public Action CloseWindow { get; set; }


        private bool CanComfirm(object parameter) 
        {
            double a;
            if (!double.TryParse(PriceText, out a)) return false;
            if (!double.TryParse(QuantityText, out a)) return false;
            return true;

        }
        private void Comfirm(object parameter) 
        {
            double p = double.Parse(PriceText);
            double q = double.Parse(QuantityText);
            bool t = TaxedText;
            int rid = RelationId;
            string r = Relation;
            ItemShared item = new ItemShared(p, q, t, rid, r);
            ItemLM.AddToTwoPeopleTotalList(item);
            CloseWindow();
        }
    }
}
