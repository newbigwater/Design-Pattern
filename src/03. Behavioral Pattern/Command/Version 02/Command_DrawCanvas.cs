using System;
using System.Collections.Generic;

namespace _03.Behavioral_Pattern.Command.Version_02
{
    public class Command_DrawCanvas : Command_Drawable
    {
        private readonly int _width;
        private readonly int _height;
        private readonly Command_MacroCommand _history;
        private readonly List<Command_Point> _drawnPoints = new List<Command_Point>();

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public Command_DrawCanvas(int width, int height, Command_MacroCommand history)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width), "Width must be positive.");
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Height must be positive.");
            }

            _history = history ?? throw new ArgumentNullException(nameof(history));
            _width = width;
            _height = height;
        }

        public void Paint()
        {
            _drawnPoints.Clear();
            _history.Execute();
        }

        public void Draw(int x, int y)
        {
            if (x < 0 || x >= _width)
            {
                throw new ArgumentOutOfRangeException(nameof(x), "X must be within canvas width.");
            }

            if (y < 0 || y >= _height)
            {
                throw new ArgumentOutOfRangeException(nameof(y), "Y must be within canvas height.");
            }

            _drawnPoints.Add(new Command_Point(x, y));
        }

        public Command_DrawSnapshot Snapshot()
        {
            return new Command_DrawSnapshot(_drawnPoints.ToArray());
        }
    }
}
