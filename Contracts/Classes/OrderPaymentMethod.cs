namespace Contracts.Classes
{
    public abstract class OrderPaymentMethod
    {
        protected User _user;

        public OrderPaymentMethod(User user)
        {
            _user = user;
        }

        public decimal CalculateCost()
        {
            var priceBeforeDiscount = CalculatePriceBeforeDiscount();
            var discount = DiscountCalculation();

            BonusAccrual();

            var finalCost = priceBeforeDiscount - discount;
            return finalCost;
        }

        protected decimal CalculatePriceBeforeDiscount()
        {
            //todo calculation
            return 0;
        }

        protected abstract decimal DiscountCalculation();
        protected abstract void BonusAccrual();
    }
}
