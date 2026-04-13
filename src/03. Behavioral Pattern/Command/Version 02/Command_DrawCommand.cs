using System;

namespace _03.Behavioral_Pattern.Command.Version_02
{
    public class Command_DrawCommand : Command_Command
    {
        private readonly Command_Drawable _drawable;
        private readonly Command_Point _position;

        public Command_DrawCommand(Command_Drawable drawable, Command_Point position)
        {
            _drawable = drawable ?? throw new ArgumentNullException(nameof(drawable));
            _position = position ?? throw new ArgumentNullException(nameof(position));
        }

        public void Execute()
        {
            _drawable.Draw(_position.X, _position.Y);
        }
    }
}
