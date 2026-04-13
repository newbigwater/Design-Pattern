namespace _03.Behavioral_Pattern.Command.Version_02
{
    public class Command_Main
    {
        private readonly Command_MacroCommand _history = new Command_MacroCommand();
        private readonly Command_DrawCanvas _canvas;

        public Command_MacroCommand History
        {
            get { return _history; }
        }

        public Command_DrawCanvas Canvas
        {
            get { return _canvas; }
        }

        public Command_Main(int width, int height)
        {
            _canvas = new Command_DrawCanvas(width, height, _history);
        }

        public Command_DrawSnapshot MouseDragged(int x, int y)
        {
            Command_Command command = new Command_DrawCommand(_canvas, new Command_Point(x, y));
            _history.Append(command);
            command.Execute();

            return _canvas.Snapshot();
        }

        public Command_DrawSnapshot ClickClearButton()
        {
            _history.Clear();
            _canvas.Paint();

            return _canvas.Snapshot();
        }

        public Command_DrawSnapshot Repaint()
        {
            _canvas.Paint();
            return _canvas.Snapshot();
        }
    }
}
