using System.Windows;

namespace FisrtWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CheckBoxHandler cbHandler = new CheckBoxHandler();
        private ItemManager iM = new ItemManager();
        private CalculateHandler cH = new CalculateHandler();
        private ListViewButtonHandler LvbH = new ListViewButtonHandler();
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = iM;
            List1.ItemsSource = iM.GetShared();
            List2.ItemsSource = iM.GetItems1();
            List3.ItemsSource = iM.GetItems2();

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
        }

        private void T2AddButton_Click(object sender, RoutedEventArgs e)
        {
            var wd = new AddItemWindow(1);
            wd.ShowDialog();
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

        private void SharedAddButton_Click(object sender, RoutedEventArgs e)
        {
            var wd = new AddItemWindow(2);
            wd.ShowDialog();
        }

        private void SharedDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            iM.RemoveFromShared(List1.SelectedIndex);
        }

        private void T1DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            iM.RemoveFromItems1(List2.SelectedIndex);
        }

        private void T2DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            iM.RemoveFromItems2(List3.SelectedIndex);
        }
    }
}
