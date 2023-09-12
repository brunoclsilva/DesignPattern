namespace DesignPatterns.Creational.FactoryMethod
{
    public class ProcessorFactoryMethod
    {
        public ProcessorFactoryMethod()
        {
            Console.WriteLine("Type the amount to calculate the discount: ");
            Decimal.TryParse(Console.ReadLine(), out decimal amount);

            Console.WriteLine("Choose a Discount Policy: ");
            Console.WriteLine("1 - Regular - 10%");
            Console.WriteLine("2 - Irregular - 20%");
            Console.WriteLine("3 - Vip - 50%");
            Int32.TryParse(Console.ReadLine(), out int discountPolicy);

            Order order;
            switch (discountPolicy)
            {
                case (int)DiscountType.Regular:
                    order = new Order(amount, new RegularDiscountPolicy());
                    break;
                case (int)DiscountType.Irregular:
                    order = new Order(amount, new IrregularDiscountPolicy());
                    break;
                case (int)DiscountType.Vip:
                    order = new Order(amount, new VipDiscountPolicy());
                    break;
                default:
                    throw new ArgumentException("Incorrect value entered!");
            }

            Console.WriteLine($"Your amount with discount applied is ${order.Amount.ToString("0.00")}");
        }
    }
}
