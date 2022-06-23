using SquareManipulationSystem.Commands;

namespace SquareManipulationSystem;
public class ManipulationSystem
{
    public List<Square> SquareList { get; set; }
    public List<(ICommand, Square?)> History;
    public (ICommand?, Square?) LastCommandRestored;

    public ManipulationSystem()
    {
        SquareList = new();
        History = new();
    }

    public Square GetSquareByNumber(int number) => SquareList.FirstOrDefault(s => s.Number == number)!;

    //public void CreateSquare(int number, int sideLength)
    //{
    //    Square square = new Square();
    //    square.Number = number;
    //    square.SideLength = sideLength;
    //    square.x = 0;
    //    square.y = 0;
    //    SquareList.Add(square);
    //}
    //public void MoveSquare(int number, int xRight, int yUpwards)
    //{
    //    Square square = SquareList.FirstOrDefault(s => s.Number == number)!;
    //    if (square is not null)
    //    {
    //        square.x = xRight;
    //        square.y = yUpwards;
    //    }
    //}
    //public void ScaleSquare(int number, int scale)
    //{
    //    var square = SquareList.FirstOrDefault(s => s.Number == number);
    //    if (square is not null)
    //    {
    //        square.SideLength = square.SideLength * scale;
    //    }
    //}
    //public void UndoLastCommand()
    //{

    //}
    //public void RedoLastCommand()
    //{

    //}
    //public void PrintSquareList()
    //{
    //    SquareList.Sort();
    //    foreach (var square in SquareList)
    //    {
    //        Console.WriteLine($"Number: {square.Number}, Horizontal position: {square.x}, " +
    //            $"Vertical position: {square.y}, Side length: {square.SideLength}");
    //    }
    //}
}

