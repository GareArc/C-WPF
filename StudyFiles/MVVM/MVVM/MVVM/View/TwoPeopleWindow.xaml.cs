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
    /// Interaction logic for TwoPeopleWindow.xaml
    /// </summary>
    public partial class TwoPeopleWindow : Window
    {
        private MainTwoPeopleItems mtp = new MainTwoPeopleItems();
        public TwoPeopleWindow()
        {
            InitializeComponent();
            mtp.CloseMainTwoPeopleWindow = new Action(() => Close());
            DataContext = mtp;
        }
    }
}
