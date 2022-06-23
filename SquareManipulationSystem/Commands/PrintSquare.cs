namespace SquareManipulationSystem.Commands;

public class PrintSquare : ICommand
{
    private ManipulationSystem _manipulationSystem;
    public bool Undoable { get; init; } = false;
    public bool Redoable { get; init; } = false;

    public PrintSquare(ManipulationSystem manipulationSystem)
    {
        _manipulationSystem = manipulationSystem;
    }

    public void Execute()
    {
        _manipulationSystem.SquareList.OrderBy(s => s.Number);
        foreach (var square in _manipulationSystem.SquareList)
        {
            Console.WriteLine($"Number: {square.Number}, Horizontal position: {square.x}, " +
                $"Vertical position: {square.y}, Side length: {square.SideLength}");
        }
        Console.WriteLine(this);
        _manipulationSystem.History.Add((this, null));
        _manipulationSystem.LastCommandRestored = (null, null);
    }
}

