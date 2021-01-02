

namespace Calculator
{
    partial class UberEatsVM
    {
        public override Shops ShopType => Shops.UberEats;
        public override string ShopName => GLOBAL.GetDescription(Shops.UberEats);
        public override double Weight => GLOBAL.UBEREATS_SERVICE_WEIGHT;
    }
}
