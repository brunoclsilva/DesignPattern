namespace DesignPatterns.Structural.Adapter
{
    public class PaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"You have paid {amount:C}.");
        }
    }
}
