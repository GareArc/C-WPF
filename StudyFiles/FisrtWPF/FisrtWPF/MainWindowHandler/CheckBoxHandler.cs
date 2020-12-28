using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Controls;

namespace FisrtWPF
{
    class CheckBoxHandler
    {
        public CheckBoxHandler() { }

        public void ChangeTextBox(TextBox target) 
        {
            if (target.Background.Equals(Brushes.White))
            {
                target.Background = (Brush)new SolidColorBrush(Color.FromRgb(0xee, 0xee, 0xee));
                target.IsReadOnly = true;
                target.Text = "";
            }
            else 
            {
                target.Background = Brushes.White;
                target.IsReadOnly = false;
            }
        }

    }
}
