using ComputerGrapho.Components.Leaf;

namespace ComputerGrapho.Components
{
    public class PriceCalculator : IVisitor
    {
        public decimal TotalPrice { get; private set; }

        public void Visit<T>(T component) where T : Component
        {
            if (component is Memory) TotalPrice += component.CalculatePrice();
        }
    }
}
