
using System.Collections.Generic;

namespace Calculator
{
    partial class GlobalVM
    {

        #region For CustomShop Basic Info

        public double CustomShopTip { get; set; } = 0;

        public double CustomShopOther { get; set; } = 0;
        #endregion

        #region For JNCShop Basic Info
        public double JNCShopTip { get; set; } = 0;

        public double JNCShopOther { get; set; } = 0;
        #endregion

        #region For UberEats Basic Info
        public double UberEatsTip { get; set; } = 0;

        public double UberEatsOther { get; set; } = 0;
        #endregion

        #region For HurryPanda Basic Info
        public double HurryPandaTip { get; set; } = 0;

        public double HurryPandaOther { get; set; } = 0;

        #endregion

        #region Calculate All Tips And Other
        public double CalculateAllTipsAndOther() 
        {
            return CustomShopTip + CustomShopOther + JNCShopTip +
                JNCShopOther + UberEatsTip + UberEatsOther + HurryPandaTip + HurryPandaOther;
        }
        #endregion
    }
}
