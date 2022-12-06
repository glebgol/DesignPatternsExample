namespace Contracts.Classes
{
    public abstract class OrderPaymentMethod
    {
        protected OrderState _order;

        public OrderPaymentMethod(OrderState order)
        {
            _order = order;
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
