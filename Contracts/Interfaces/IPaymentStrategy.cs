namespace Contracts.Interfaces
{
    public interface IPaymentStrategy
    {
        bool IsAvailable { get; }
        void Pay(decimal amount);
    }
}
