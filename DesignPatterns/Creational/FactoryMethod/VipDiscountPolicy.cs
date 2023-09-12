namespace DesignPatterns.Creational.FactoryMethod
{
    public class VipDiscountPolicy : DiscountPolicy
    {
        public override Discount Create() => new VipDiscount();
    }
}
