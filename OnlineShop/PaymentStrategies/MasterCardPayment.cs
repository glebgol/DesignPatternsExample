using Contracts.Interfaces;

namespace OnlineShop.PaymentStrategies
{
    public class MasterCardPayment : IPaymentStrategy
    {
        public bool IsAvailable
        {
            get
            {
                return true;
            }
        }

        public void Pay(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
