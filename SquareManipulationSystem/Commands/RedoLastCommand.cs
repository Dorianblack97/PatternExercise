namespace SquareManipulationSystem.Commands;

public class RedoLastCommand : SquareBackupper, ICommand
{
    private ManipulationSystem _manipulationSystem;
    public bool Undoable { get; init; } = false;
    public bool Redoable { get; init; } = true;
    public RedoLastCommand(ManipulationSystem manipulationSystem)
    {
        _manipulationSystem = manipulationSystem;
    }
    public void Execute()
    {
        if (_manipulationSystem.LastCommandRestored.Item1 is not null)
        {
            var lastCommand = _manipulationSystem.History.Last();
            if (lastCommand.Item1.Redoable)
            {
                var redoSquare = _manipulationSystem.LastCommandRestored.Item2!;
                var square = _manipulationSystem.GetSquareByNumber(redoSquare.Number);
                square.Copy(redoSquare);
                _manipulationSystem.LastCommandRestored = (null, null);
                _manipulationSystem.History.Add((this, null));
                Console.WriteLine(this);
            }
        }
    }
}
