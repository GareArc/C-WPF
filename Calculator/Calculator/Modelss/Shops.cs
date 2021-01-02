
using System.ComponentModel;

namespace Calculator
{
    public enum Shops
    {
        [Description("金牛城超市(Online)")]
        JinNiuCheng,
        [Description("UberEats")]
        UberEats,
        [Description("熊猫外卖HurryPanda")]
        HurryPanda,
        [Description("普通商店")]
        CustomShop,
    }
}
