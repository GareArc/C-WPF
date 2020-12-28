using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FisrtWPF
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        private ItemManager itemM = new ItemManager();
        private int Source;
        public AddItemWindow(int source)
        {
            this.Source = source;
            InitializeComponent();
        }

        private void ComfirmButton_Click(object sender, RoutedEventArgs e)
        {
            //Save data and store it in the ItemManager
            string txt = PriceTextBox.Text;
            string qt = QuantityTextBox.Text;
            bool? ck = TaxButton.IsChecked;

            bool succeed;
            if (this.Source == 0) succeed = itemM.AddToList1(txt.Trim(), qt.Trim(), ck);
            else succeed = itemM.AddToList2(txt.Trim(), qt.Trim(), ck);

            if (!succeed) 
            {
                MessageBox.Show("错误输入信息,请复查。");
                return;
            }
            //Close window
            this.Close();
        }
    }
}
