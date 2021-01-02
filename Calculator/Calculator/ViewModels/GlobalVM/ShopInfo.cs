
using System.Collections.Generic;

namespace Calculator
{
    partial class GlobalVM
    {

        #region Tips Dictionary
        public Dictionary<Shops, double> ShopTips { get; set; } = new Dictionary<Shops, double>();
        #endregion

        #region Others Dictionary
        public Dictionary<Shops, double> ShopOthers { get; set; } = new Dictionary<Shops, double>();
        #endregion

        #region Calculate All Tips And Other
        public double CalculateAllTipsAndOther() 
        {
            double result = 0;
            foreach (var tip in ShopTips.Values) 
            {
                result += tip;
            }

            foreach (var other in ShopOthers.Values)
            {
                result += other;
            }
            return result;
        }
        #endregion
    }
}
