namespace DesignPatterns.Creational.FactoryMethod
{
    public class RegularDiscount : Discount
    {
        public override decimal GetPercentage() => 0.1m;
    }
}
