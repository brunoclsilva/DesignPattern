namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class DiscountPolicy
    {
        public abstract Discount Create();

        public decimal Apply(decimal Price)
        {
            var discount = Create();
            return Price * (1 - discount.GetPercentage());
        }
    }
}
