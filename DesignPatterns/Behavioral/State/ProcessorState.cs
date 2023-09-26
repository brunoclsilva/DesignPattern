namespace DesignPatterns.Behavioral.State
{
    public class ProcessorState
    {
        public ProcessorState()
        {
            Console.WriteLine($"Creating invoice...");
            var invoice = new Invoice(123, 1000m, "Software Dev Services");

            invoice.Pay();
            invoice.Refund();
        }
    }
}
