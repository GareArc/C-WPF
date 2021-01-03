using System.Collections.ObjectModel;

namespace Calculator
{
    partial class GlobalVM
    {
        #region ViewLists
        // SharedList
        public ObservableCollection<ShoppingItem> SharedListTotal { get; set; } = new ObservableCollection<ShoppingItem>();

        // Target1List
        public ObservableCollection<ShoppingItem> Target1ListTotal { get; set; } = new ObservableCollection<ShoppingItem>();

        //Targe2List
        public ObservableCollection<ShoppingItem> Target2ListTotal { get; set; } = new ObservableCollection<ShoppingItem>();
        #endregion

        #region Add/Delete
        public void AddToSharedListTotal(ShoppingItem item) { AddItemHelper(SharedListTotal, item); }
        public void AddToTarget1ListTotal(ShoppingItem item) { AddItemHelper(Target1ListTotal, item); }
        public void AddToTarget2ListTotal(ShoppingItem item) { AddItemHelper(Target2ListTotal, item); }

        public void DeleteFromSharedListTotal(ShoppingItem item) { DeleteItemHelper(SharedListTotal, item); }
        public void DeleteFromTarget1ListTotal(ShoppingItem item) { DeleteItemHelper(Target1ListTotal, item); }
        public void DeleteFromTarget2ListTotal(ShoppingItem item) { DeleteItemHelper(Target2ListTotal, item); }


        private void AddItemHelper(ObservableCollection<ShoppingItem> list, ShoppingItem item) 
        {
            list.Add(item);
        }
        private void DeleteItemHelper(ObservableCollection<ShoppingItem> list, ShoppingItem item) 
        {
            if(item != null) list.Remove(item);
        }

        #endregion

        #region Calculate
        public double CalculateForSharedList() { return CalculateHelper(SharedListTotal); }
        public double CalculateForTarget1ListTotal() { return CalculateHelper(Target1ListTotal); }
        public double CalculateForTarget2ListTotal() { return CalculateHelper(Target2ListTotal); }

        private double CalculateHelper(ObservableCollection<ShoppingItem> list) 
        {
            double result = 0;
            foreach (var item in list)
            {
                result += item.Calculate();
            }
            return result;
        }
        #endregion
        
        #region Clear
        public void ClearLists() 
        {
            SharedListTotal = new ObservableCollection<ShoppingItem>();
            Target1ListTotal = new ObservableCollection<ShoppingItem>();
            Target2ListTotal = new ObservableCollection<ShoppingItem>();
        }
        #endregion
    }
}
