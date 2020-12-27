using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FisrtWPF
{
    class CheckBoxHandler
    {
        public CheckBoxHandler() { }

        public void CheckBoxChangedHelper(ref string text, ref bool isReadOnly, ref Brush color) 
        {
            if (color.Equals(Brushes.White))
            {
                color = (Brush)new SolidColorBrush(Color.FromRgb(0xee, 0xee, 0xee));
                isReadOnly = true;
                text = "";
            }
            else 
            {
                color = Brushes.White;
                isReadOnly = false;
            }
        }
    }
}
