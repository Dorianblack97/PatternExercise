namespace SquareManipulationSystem.Commands
{
    public interface ICommand
    {
        public bool Undoable { get; init; }
        public bool Redoable { get; init; }

        void Execute();
    }
}
