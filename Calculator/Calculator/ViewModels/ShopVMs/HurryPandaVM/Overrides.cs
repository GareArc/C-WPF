

namespace Calculator
{
    partial class HurryPandaVM
    {
        public override Shops ShopType => Shops.HurryPanda;
        public override double Weight => GLOBAL.HURRYPANDA_SERVICE_WEIGHT;
        public override string ShopName => GLOBAL.GetDescription(Shops.HurryPanda);
    }
}
