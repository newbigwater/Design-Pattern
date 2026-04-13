using System;

namespace _03.Behavioral_Pattern.Command.Version_02
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
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(x), "X must be zero or positive.");
            }

            if (y < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y), "Y must be zero or positive.");
            }

            _x = x;
            _y = y;
        }
    }
}
