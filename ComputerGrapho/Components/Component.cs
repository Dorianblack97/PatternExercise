namespace ComputerGrapho.Components;

public abstract class Component
{
    public virtual void Accept(IVisitor visitor)
    {
        throw new NotImplementedException();
    }
    public abstract decimal CalculatePrice();
    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }
    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }
    public virtual bool IsComposite() => true;
}
