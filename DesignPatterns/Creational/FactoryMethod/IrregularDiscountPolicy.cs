namespace DesignPatterns.Creational.FactoryMethod
{
    public class IrregularDiscountPolicy : DiscountPolicy
    {
        public override Discount Create() => new IrregularDiscount();
    }
}
