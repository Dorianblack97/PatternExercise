namespace SquareManipulationSystem.Commands;

public class ScaleSquare : SquareBackupper, ICommand
{
    private ManipulationSystem _manipulationSystem;
    private int _squareNumber;
    private int _multiplier;
    public bool Undoable { get; init; } = true;
    public bool Redoable { get; init; } = false;



    public ScaleSquare(ManipulationSystem manipulationSystem, int squareNumber, int multiplier)
    {
        _manipulationSystem = manipulationSystem;
        _squareNumber = squareNumber;
        _multiplier = multiplier;
    }

    public void Execute()
    {
        var squareToManipulate = _manipulationSystem.GetSquareByNumber(_squareNumber);
        if (squareToManipulate is not null)
        {
            _manipulationSystem.History.Add((this, SquareBackup(squareToManipulate)));
            squareToManipulate.SideLength = squareToManipulate.SideLength * _multiplier;
            _manipulationSystem.LastCommandRestored = (null, null);
            Console.WriteLine(this);
        }
    }
}
