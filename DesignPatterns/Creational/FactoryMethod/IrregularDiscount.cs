namespace DesignPatterns.Creational.FactoryMethod
{
    public class IrregularDiscount : Discount
    {
        public override decimal GetPercentage() => 0.2m;
    }
}
