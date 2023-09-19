namespace DesignPatterns.Structural.Adapter
{
    public class PaymentProviderAdapter : IPaymentProvider
    {
        private readonly PaymentProcessor _paymentProcessor;

        public PaymentProviderAdapter(PaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void MakePayment(string details, decimal amount)
        {
            Console.WriteLine($"Making a payment for: {details}");
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
