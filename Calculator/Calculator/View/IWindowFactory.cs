using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IWindowFactory
    {
        void OpenMainWindow(bool IsIndependent = true);
        void OpenAddItemWindow();
        void OpenShopWindow(Shops ShopType);
        void ResetAllWindows();

    }
}
