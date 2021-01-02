

namespace Calculator
{
    partial class CustomShopVM
    {
        public override Shops ShopType => Shops.CustomShop;
        public override string ShopName => GLOBAL.GetDescription(Shops.CustomShop);
        public override double Weight => GLOBAL.CUSTOM_SERVICE_WEIGHT;
    }
}
