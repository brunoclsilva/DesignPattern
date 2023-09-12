namespace DesignPatterns.Creational.FactoryMethod
{
    public class VipDiscount : Discount
    {
        public override decimal GetPercentage() => 0.5m;
    }
}
