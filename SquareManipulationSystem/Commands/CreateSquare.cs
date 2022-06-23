namespace SquareManipulationSystem.Commands;

public class CreateSquare : SquareBackupper, ICommand
{
    private ManipulationSystem _manipulationSystem;
    private Square _square;
    public bool Undoable { get; init; } = true;
    public bool Redoable { get; init; } = false;


    public CreateSquare(ManipulationSystem manipulationSystem, int number, int sideLength)
    {
        _manipulationSystem = manipulationSystem;
        _square = new Square();
        _square.Number = number;
        _square.SideLength = sideLength;
        _square.x = 0;
        _square.y = 0;
    }
    public void Execute()
    {
        _manipulationSystem.SquareList.Add(_square);
        _manipulationSystem.History.Add((this, null));
        _manipulationSystem.LastCommandRestored = (null, null);
        Console.WriteLine(this);
    }
}
