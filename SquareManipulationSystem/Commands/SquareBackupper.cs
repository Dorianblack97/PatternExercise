namespace SquareManipulationSystem.Commands
{
    public abstract class SquareBackupper
    {
        public Square SquareBackup(Square square)
        {
            var squareBackup = new Square();
            squareBackup.Number = square.Number;
            squareBackup.SideLength = square.SideLength;
            squareBackup.x = square.x;
            squareBackup.y = square.y;

            return squareBackup;
        }
    }
}
