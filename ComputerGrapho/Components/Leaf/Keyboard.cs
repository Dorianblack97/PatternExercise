namespace ComputerGrapho.Components.Leaf;

public class Keyboard : Component
{
    decimal Price = 0;
    public Keyboard(decimal price)
    {
        Price = price;
    }
    public override decimal CalculatePrice() => Price;
    public override bool IsComposite() => false;
    public override void Accept(IVisitor visitor) => visitor.Visit(this);

}
