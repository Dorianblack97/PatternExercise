namespace SquareManipulationSystem.Commands;

public class UndoLastCommand : SquareBackupper, ICommand
{
    private ManipulationSystem _manipulationSystem;
    public bool Undoable { get; init; } = false;
    public bool Redoable { get; init; } = true;

    public UndoLastCommand(ManipulationSystem manipulationSystem)
    {
        _manipulationSystem = manipulationSystem;
    }

    public void Execute()
    {
        if (_manipulationSystem.History.Count > 0)
        {
            var lastCommand = _manipulationSystem.History.Last();
            if (lastCommand.Item1.Undoable)
            {
                var undoSquare = lastCommand.Item2;
                if (undoSquare is not null)
                {
                    var square = _manipulationSystem.GetSquareByNumber(undoSquare.Number);
                    _manipulationSystem.History.Add((this, SquareBackup(square)));
                    _manipulationSystem.LastCommandRestored = (this, SquareBackup(square));
                    square.Copy(undoSquare);
                    Console.WriteLine(this);
                }
                else
                {
                    _manipulationSystem.History.Add((this, SquareBackup(_manipulationSystem.SquareList.Last())));
                    _manipulationSystem.LastCommandRestored = (this, SquareBackup(_manipulationSystem.SquareList.Last()));
                    _manipulationSystem.SquareList.Remove(_manipulationSystem.SquareList.Last());
                }
            }
        }
    }
}