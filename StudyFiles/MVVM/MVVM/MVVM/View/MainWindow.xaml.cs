using System.Windows;
using System;

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel mw = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mw;
            mw.CloseMainWindow = new Action(() => this.Close());
        }
    }
}
