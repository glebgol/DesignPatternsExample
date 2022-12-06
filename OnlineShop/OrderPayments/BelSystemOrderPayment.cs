using Contracts.Classes;

namespace OnlineShop.OrderPayments
{
    public class BelSystemOrderPayment : OrderPaymentMethod
    {
        public BelSystemOrderPayment(User user) : base(user)
        {
        }

        protected override void BonusAccrual()
        {
            throw new NotImplementedException();
        }

        protected override decimal DiscountCalculation()
        {
            throw new NotImplementedException();
        }
    }
}
