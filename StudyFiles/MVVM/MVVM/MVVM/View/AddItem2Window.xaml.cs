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
    /// Interaction logic for AddItem2Window.xaml
    /// </summary>
    public partial class AddItem2Window : Window
    {
        private AddItem2ViewModel mat2;
        public AddItem2Window(int rid, string r)
        {
            InitializeComponent();
            mat2 = new AddItem2ViewModel(rid, r);
            mat2.CloseWindow = new Action(() => Close());
            DataContext = mat2;
        }
    }
}
