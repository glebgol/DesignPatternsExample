namespace Contracts.Interfaces
{
    public interface IShopFactory
    {
        IProductRepository ProductRepository { get; }
    }
}
