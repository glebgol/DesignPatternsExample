namespace Contracts.Classes
{
    public abstract class OrderState
    {

        public abstract void Pay();
        public abstract void Cancel();
        public abstract void Delete();
    }
}
