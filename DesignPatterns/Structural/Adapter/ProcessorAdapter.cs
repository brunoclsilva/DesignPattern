namespace DesignPatterns.Structural.Adapter
{
    public class ProcessorAdapter
    {
        public ProcessorAdapter()
        {
            Console.WriteLine("Type the name of the company you want to pay: ");
            string company = Console.ReadLine() ?? String.Empty;

            Console.WriteLine("Type the amount you want to pay: ");
            Decimal.TryParse(Console.ReadLine(), out decimal amount);

            var paymentProcessor = new PaymentProcessor();
            var paymentProvider = new PaymentProviderAdapter(paymentProcessor);

            paymentProvider.MakePayment(company, amount);
        }
    }
}
