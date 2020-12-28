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
        private PanelHandler pH = new PanelHandler();
        private ItemManager iM = new ItemManager();
        private CalculateHandler cH = new CalculateHandler();
        //private ResetHandler resetH = new ResetHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        #region CheckBox Change
        private void amzCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            cbHandler.ChangeTextBox(amzTextBox);
        }

        private void dfCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            cbHandler.ChangeTextBox(dfTextBox);
        }

        private void wfCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            cbHandler.ChangeTextBox(wfTextBox);
        }

        private void amzpCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            amzpTextBox.Text = "(默认)";
            cbHandler.ChangeTextBox(amzpTextBox);
            
        }

        private void wmCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            cbHandler.ChangeTextBox(wmTextBox);
        }

        private void zxCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            cbHandler.ChangeTextBox(zxTextBox);
        }

        #endregion

        #region Add Button Click
        private void T1AddButton_Click(object sender, RoutedEventArgs e)
        {
            var wd = new AddItemWindow(0);
            wd.ShowDialog();
            if (!iM.GetUpdateInfo()) return;
            pH.AddTextBlock(Target1Panel, iM.GetLastItemInfo());
            iM.FinishUpdate();
        }

        private void T2AddButton_Click(object sender, RoutedEventArgs e)
        {
            var wd = new AddItemWindow(1);
            wd.ShowDialog();
            if (!iM.GetUpdateInfo()) return;
            pH.AddTextBlock(Target2Panel, iM.GetLastItemInfo());
            iM.FinishUpdate();
        }

        #endregion


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool succeed = cH.ShowTotal(this);
            if (!succeed) 
            {
                ShowMsgBox("有错误输入,请检查。");
                Output1.Text = "Error";
                Output2.Text = "Error";
            }
        }

        public void ShowMsgBox(string info)
        {
            MessageBox.Show(info);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newMain = new MainWindow();
            newMain.Show();
            Close();
        }
    }
}
