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
    /// Interaction logic for Target2.xaml
    /// </summary>
    public partial class Target2Window : Window
    {
        private MainTarget2Items mt2 = new MainTarget2Items();
        public Target2Window()
        {
            InitializeComponent();
            mt2.CloseTarget2Window = new Action(() => this.Close());
            DataContext = mt2;
        }
    }
}
