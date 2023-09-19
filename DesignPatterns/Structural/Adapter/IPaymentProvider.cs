namespace DesignPatterns.Structural.Adapter
{
    public interface IPaymentProvider
    {
        void MakePayment(string details, decimal amount);
    }
}
