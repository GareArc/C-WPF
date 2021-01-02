﻿

namespace Calculator
{
    partial class CustomShopVM
    {
        public override BasicItem CreateBasicItem()
        {
            // Open AddItemWindow
            windowF.OpenAddItemWindow();

            // Check if there's new item being added
            if (!globalVM.AddedNewItem) return null;

            // New item is added, so get the info
            double price = globalVM.LastItemPrice;
            double quantity = globalVM.LastItemQuantity;
            bool taxed = globalVM.LastItemIsTaxed;

            // Update item info and create new item
            globalVM.AddedNewItem = false;
            return new BasicItem(price, quantity, taxed, GLOBAL.CUSTOM_SERVICE_WEIGHT, ShopName);
        }

        public override SharedItem CreateSharedItem()
        {
            // Open AddItemWindow
            windowF.OpenAddItemWindow();

            // Check if there's new item being added
            if (!globalVM.AddedNewItem) return null;

            // New item is added, so get the info
            double price = globalVM.LastItemPrice;
            double quantity = globalVM.LastItemQuantity;
            bool taxed = globalVM.LastItemIsTaxed;

            // Update item info and create new item
            globalVM.AddedNewItem = false;
            return new SharedItem(price, quantity, taxed, GLOBAL.CUSTOM_SERVICE_WEIGHT, 
                GetRelationType(), ChoiceList_Relation[SeletedIndex_Relation], ShopName);
        }

        public override void Confirm(object parameter)
        {
            globalVM.CustomShopTip = double.Parse(Tip);
            globalVM.CustomShopOther = double.Parse(Other);
            CloseWindow();
        }
    }
}
