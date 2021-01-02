

namespace Calculator
{
    partial class JNCShopVM
    {
        public override Shops ShopType => Shops.JinNiuCheng;
        public override string ShopName => GLOBAL.GetDescription(Shops.JinNiuCheng);
        public override double Weight => GLOBAL.JNC_SERVICE_WEIGHT;
    }
}
