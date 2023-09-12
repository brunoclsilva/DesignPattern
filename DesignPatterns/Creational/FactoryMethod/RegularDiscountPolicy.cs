namespace DesignPatterns.Creational.FactoryMethod
{
    public class RegularDiscountPolicy : DiscountPolicy
    {
        public override Discount Create() => new RegularDiscount();
    }
}
