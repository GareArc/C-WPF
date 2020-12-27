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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FisrtWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CheckBoxHandler cbHandler = new CheckBoxHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void amzCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            bool isReadOnly = amzTextBox.IsReadOnly;
            Brush color = amzTextBox.Background;
            string text = amzTextBox.Text;
            cbHandler.CheckBoxChangedHelper(ref text, ref isReadOnly, ref color);
            amzTextBox.IsReadOnly = isReadOnly;
            amzTextBox.Background = color;
            amzTextBox.Text = text;
        }

        private void dfCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            dfTextBox.IsReadOnly = !dfTextBox.IsReadOnly;
        }

        private void wfCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            wfTextBox.IsReadOnly = !wfTextBox.IsReadOnly;
        }

        private void amzpCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            amzpTextBox.IsReadOnly = !amzpTextBox.IsReadOnly;
        }

        private void wmCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            wmTextBox.IsReadOnly = !wmTextBox.IsReadOnly;
        }

        private void zxCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            zxTextBox.IsReadOnly = !zxTextBox.IsReadOnly;
        }
    }
}
