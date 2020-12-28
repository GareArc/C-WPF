using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace FisrtWPF
{
    class CalculateHandler
    {
        private ItemManager iM = new ItemManager();

        public CalculateHandler() { }

        public bool ShowTotal(MainWindow main) 
        {
            //Process shared fees.
            double SharedTotal = 0;
            string dftxt = main.dfTextBox.Text;
            bool? dfc = main.dfCheckBox.IsChecked;
            string wftxt = main.wfTextBox.Text;
            bool? wfc = main.wfCheckBox.IsChecked;
            string amztxt = main.amzTextBox.Text;
            bool? amzc = main.amzCheckBox.IsChecked;
            string amzptxt = main.amzpTextBox.Text;
            bool? amzpc = main.amzpCheckBox.IsChecked;
            string wmtxt = main.wmTextBox.Text;
            bool? wmc = main.wmCheckBox.IsChecked;
            string zxtxt = main.zxTextBox.Text;
            bool? zxc = main.zxCheckBox.IsChecked;

            if (!RegisterValue(ref SharedTotal, dftxt, dfc)) return false;
            if (!RegisterValue(ref SharedTotal, wftxt, wfc)) return false;
            if (!RegisterValue(ref SharedTotal, amztxt, amzc)) return false;
            if (!RegisterValue(ref SharedTotal, amzptxt, amzpc)) return false;
            if (!RegisterValue(ref SharedTotal, wmtxt, wmc)) return false;
            if (!RegisterValue(ref SharedTotal, zxtxt, zxc)) return false;

            //Process individual
            double Individual1 = iM.CalculatePriceIn1();
            double Individual2 = iM.CalculatePriceIn2();

            //Calculate total
            double Total1 = Individual1 + (SharedTotal / 3);
            double Total2 = Individual2 + (SharedTotal / 3);
            //Modify TextBlocks
            main.Output1.Text = "对象1总计: " + Math.Round(Total1, 2);
            main.Output2.Text = "对象2总计: " + Math.Round(Total2, 2);

            return true;

        }

        private bool RegisterValue(ref double shared, string value, bool? IsChecked) 
        {
            if (IsChecked == true) 
            {
                double Nvalue;
                if (!double.TryParse(value, out Nvalue)) return false;
                shared += Nvalue;
            }
            return true;
        }

    }
}
