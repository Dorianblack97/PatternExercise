namespace SquareManipulationSystem.Commands
{
    public class MoveSquare : SquareBackupper, ICommand
    {
        private ManipulationSystem _manipulationSystem;
        private int _squareNumber;
        private int _xRight;
        private int _yUpwards;
        public bool Undoable { get; init; } = true;
        public bool Redoable { get; init; } = false;

        public MoveSquare(ManipulationSystem manipulationSystem, int squareNumber, int xRight, int yUpwards)
        {
            _manipulationSystem = manipulationSystem;
            _squareNumber = squareNumber;
            _xRight = xRight;
            _yUpwards = yUpwards;
        }
        public void Execute()
        {
            var squareToManipulate = _manipulationSystem.GetSquareByNumber(_squareNumber);
            if (squareToManipulate is not null)
            {
                _manipulationSystem.History.Add((this, SquareBackup(squareToManipulate)));
                squareToManipulate.x = _xRight;
                squareToManipulate.y = _yUpwards;
                _manipulationSystem.LastCommandRestored = (null, null);
                Console.WriteLine(this);
            }
        }

    }
}
