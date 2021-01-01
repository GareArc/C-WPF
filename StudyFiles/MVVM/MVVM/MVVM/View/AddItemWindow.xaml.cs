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

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        private AddItem1ViewModel aw;
        public AddItemWindow(int Source)
        {
            InitializeComponent();
            aw = new AddItem1ViewModel(Source);
            DataContext = aw;
            aw.CloseWindow = new Action(() => this.Close());

        }
    }
}
