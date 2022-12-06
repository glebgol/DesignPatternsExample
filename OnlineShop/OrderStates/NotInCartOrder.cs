using Contracts.Classes;

namespace OnlineShop.OrderStates
{
    public class NotInCartOrder : OrderState
    {
        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Pay()
        {
            throw new NotImplementedException();
        }
    }
}
