namespace AMazeCS
{
    public class Position
    {
        public int X { private set; get; }
        public int Y { private set; get; }
        public Position From { private set; get; }
        public Position(int x, int y, Position from)
        {
            X = x;
            Y = y;
            From = from;
        }
        public Position(int x, int y) : this(x, y, null) { }
    }
}
