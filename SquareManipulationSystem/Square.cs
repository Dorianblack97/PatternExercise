namespace SquareManipulationSystem;
public class Square
{
    public int Number { get; set; }
    public int SideLength { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public void Copy(Square square)
    {
        this.Number = square.Number;
        this.SideLength = square.SideLength;
        this.x = square.x;
        this.y = square.y;
    }

}

