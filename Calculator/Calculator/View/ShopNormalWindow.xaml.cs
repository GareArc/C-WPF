using System;
using System.Windows;

namespace Calculator.View
{
    /// <summary>
    /// Interaction logic for ShopNormal.xaml
    /// </summary>
    public partial class ShopNormal : Window
    {
        public ShopNormal(IShopVM DataContext)
        {
            DataContext.SetCloseWindowAction(new Action(() => Close()));
            this.DataContext = DataContext;
            InitializeComponent();
        }
    }
}
