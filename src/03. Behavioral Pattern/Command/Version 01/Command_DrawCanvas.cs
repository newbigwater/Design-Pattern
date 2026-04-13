using System.Collections.Generic;

namespace _03.Behavioral_Pattern.Command.Version_01
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
            _width = width;
            _height = height;
            _history = history;
        }

        public void Paint()
        {
            _drawnPoints.Clear();
            _history.Execute();
        }

        public void Draw(int x, int y)
        {
            _drawnPoints.Add(new Command_Point(x, y));
        }

        public Command_Point[] GetDrawnPoints()
        {
            return _drawnPoints.ToArray();
        }
    }
}
