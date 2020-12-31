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
        private MainAddItem2Items mat2;
        public AddItem2Window(int rid, string r)
        {
            InitializeComponent();
            mat2 = new MainAddItem2Items(rid, r);
            mat2.CloseWindow = new Action(() => Close());
            DataContext = mat2;
        }
    }
}
