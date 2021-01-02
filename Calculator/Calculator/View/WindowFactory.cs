using Calculator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    public class WindowFactory : IWindowFactory
    {
        public WindowFactory() 
        {
            ResetAllWindows();
        }
        #region Singleton    
        private static WindowFactory _Instance;
        public static WindowFactory GetInstance() 
        {
            if (_Instance == null) _Instance = new WindowFactory();
            return _Instance;
        }
        #endregion

        #region Instances
        private CustomShopVM CustomShopVM;
        private JNCShopVM JNCShopVM;
        private UberEatsVM UberEatsVM;
        private HurryPandaVM HurryPandaVM;

        public void ResetAllWindows()
        {
            CustomShopVM = new CustomShopVM(this);
            JNCShopVM = new JNCShopVM(this);
            UberEatsVM = new UberEatsVM(this);
            HurryPandaVM = new HurryPandaVM(this);
        }
        #endregion

        public void OpenMainWindow(bool IsIndependent = true) 
        {
            MainWindow main = new MainWindow();
            if (IsIndependent) main.Show();
            else main.ShowDialog();
        }

        public void OpenAddItemWindow()
        {
            AddItemWindow w = new AddItemWindow();
            w.ShowDialog();
        }

        public void OpenShopWindow(Shops ShopType) 
        {
            IShopVM vm= null;
            switch (ShopType) 
            {
                case Shops.JinNiuCheng:
                    vm = JNCShopVM;
                    break;
                case Shops.UberEats:
                    vm = UberEatsVM;
                    break;
                case Shops.HurryPanda:
                    vm = HurryPandaVM;
                    break;
                default:
                    vm = CustomShopVM;
                    break;
            }
            Window w = new ShopNormal(vm);
            w.ShowDialog();
        }
    }
}
