namespace ComputerGrapho.Components.Nodes;

public class GraphicCard : Component
{
    protected List<Component> _children = new List<Component>();
    public override decimal CalculatePrice()
    {
        decimal Price = 0;
        foreach (var component in _children)
        {
            Price += component.CalculatePrice();
        }
        return Price;
    }
    public void VisitChild(IVisitor visitor)
    {
        foreach (var component in _children)
        {
            component.Accept(visitor);
        }
    }
    public override void Add(Component component) => _children.Add(component);
    public override void Remove(Component component) => _children.Remove(component);
    public override void Accept(IVisitor visitor) => VisitChild(visitor);
}
