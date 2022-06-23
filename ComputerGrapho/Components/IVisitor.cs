namespace ComputerGrapho.Components;

public interface IVisitor
{
    void Visit<T>(T component) where T : Component;
}