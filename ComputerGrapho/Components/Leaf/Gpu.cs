namespace ComputerGrapho.Components.Leaf;

public class Gpu : Component
{
    decimal Price = 0;
    public Gpu(decimal price)
    {
        Price = price;
    }
    public override decimal CalculatePrice() => Price;
    public override bool IsComposite() => false;
    public override void Accept(IVisitor visitor) => visitor.Visit(this);
}
