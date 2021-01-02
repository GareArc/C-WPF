
namespace Calculator
{
    partial class UberEatsVM
    {
        public string ShopName { get; } = GLOBAL.GetDescription(Shops.UberEats);
        public override Shops ShopType => Shops.UberEats;
    }
}
