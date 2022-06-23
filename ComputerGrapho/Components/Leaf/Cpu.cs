namespace ComputerGrapho.Components.Leaf;

public class Cpu : Component
{
    decimal Price = 0;
    public Cpu(decimal price)
    {
        Price = price;
    }
    public override decimal CalculatePrice() => Price;
    public override bool IsComposite() => false;
    public override void Accept(IVisitor visitor) => visitor.Visit(this);
}
