
using System.Collections.Generic;
using System.Windows.Input;

namespace Calculator
{
    partial class MainWindowVM
    {
        #region ComboBox
        public List<Shops> ChoiceList_Shops { get; set; } = new List<Shops> 
        {
            Shops.CustomShop,
            Shops.JinNiuCheng,
            Shops.UberEats,
            Shops.HurryPanda,
        };

        public Shops SeletedItem_Shop { get; set; } = Shops.CustomShop;
        #endregion

        #region ShopButton
        public ICommand ShopBtnCmd { get { return new UnconditionalCmd(OpenShopWindows); } }
        private void OpenShopWindows(object parameter) 
        {
            windowF.OpenShopWindow(SeletedItem_Shop);
        }
        #endregion
    }
}
