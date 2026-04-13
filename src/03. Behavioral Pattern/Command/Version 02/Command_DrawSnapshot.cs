namespace _03.Behavioral_Pattern.Command.Version_02
{
    public sealed class Command_DrawSnapshot
    {
        private readonly Command_Point[] _points;

        public Command_Point[] Points
        {
            get { return _points; }
        }

        public int Count
        {
            get { return _points.Length; }
        }

        public Command_DrawSnapshot(Command_Point[] points)
        {
            _points = points;
        }
    }
}
