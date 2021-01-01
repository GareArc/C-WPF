using System.Windows.Input;
using System;

namespace MVVM
{
    partial class AddItem1ViewModel
    {
        public ICommand ComfirmCmd { get; set; }
        public int Source;
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
            Item NewItem = new Item(p, q, t);
            AddItemToLists(NewItem, Source);
            CloseWindow();
        }

        public void AddItemToLists(Item i, int Source) 
        {
            switch (Source) 
            {
                case 0:
                    ItemLM.AddToSharedList(i);
                    return;
                case 1:
                    ItemLM.AddToList1(i);
                    return;
                case 2:
                    ItemLM.AddToList2(i);
                    return;
            }
        }
    }
}
