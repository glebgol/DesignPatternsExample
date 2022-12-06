using Contracts.Classes;

namespace OnlineShop.OrderPayments
{
    public class BelSystemOrderPayment : OrderPaymentMethod
    {
        public BelSystemOrderPayment(OrderState order) : base(order)
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
