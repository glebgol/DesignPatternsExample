using Contracts.Interfaces;

namespace OnlineShop.Shop
{
    public class VitalurShop : IShopFactory
    {
        public IProductRepository ProductRepository => throw new NotImplementedException();
    }
}
