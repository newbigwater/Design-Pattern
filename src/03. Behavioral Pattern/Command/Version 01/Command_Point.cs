namespace _03.Behavioral_Pattern.Command.Version_01
{
    public class Command_Point
    {
        private readonly int _x;
        private readonly int _y;

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public Command_Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
