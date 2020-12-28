using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FisrtWPF
{
    class ResetHandler
    {
        private ItemManager iM = new ItemManager();
        public ResetHandler() { }

        public void Reset(StackPanel p1, StackPanel p2) 
        {
            // clear itemlist
            iM.ClearAll();
            // clear TextBlocks
            ClearTextBlocks(p1, p2);
            //
            
        }

        private void ClearTextBlocks(StackPanel p1, StackPanel p2) 
        {
            // clear panel 1
            var t1 = p1.Children[0];
            var t2 = p1.Children[1];
            p1.Children.Clear();
            p1.Children.Add(t1);
            p1.Children.Add(t2);

            // clear panel 2
            var t3 = p2.Children[0];
            var t4 = p2.Children[1];
            p2.Children.Clear();
            p2.Children.Add(t3);
            p2.Children.Add(t4);
        }


    }
}
