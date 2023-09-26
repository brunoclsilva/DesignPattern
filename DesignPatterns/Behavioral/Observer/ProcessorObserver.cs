namespace DesignPatterns.Behavioral.Observer
{
    public class ProcessorObserver
    {
        public ProcessorObserver()
        {
            var stockName = "ABC";
            var initialPrice = 100m;
            Console.WriteLine($"Stock {stockName} initial price: {initialPrice}");
            var stock = new Stock(stockName, initialPrice);

            Console.WriteLine("Creating two observers, Diplay and Logger...");
            var display = new Display(stock);
            var logger = new Logger(stock, "stock.txt");

            decimal newPrice;
            Console.WriteLine("Type the new price: ");
            Decimal.TryParse(Console.ReadLine(), out newPrice);
            stock.Price = newPrice;

            Console.WriteLine("Unsubscribing Logger...");
            stock.Unsubscribe(logger);

            Console.WriteLine("Type another new price: ");
            Decimal.TryParse(Console.ReadLine(), out newPrice);
            stock.Price = newPrice;
        }
    }
}
