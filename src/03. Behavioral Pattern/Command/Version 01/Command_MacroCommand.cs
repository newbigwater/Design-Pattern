using System.Collections.Generic;

namespace _03.Behavioral_Pattern.Command.Version_01
{
    public class Command_MacroCommand : Command_Command
    {
        private readonly List<Command_Command> _commands = new List<Command_Command>();

        public int Count
        {
            get { return _commands.Count; }
        }

        public void Execute()
        {
            foreach (Command_Command command in _commands)
            {
                command.Execute();
            }
        }

        public void Append(Command_Command command)
        {
            if (command != this)
            {
                _commands.Add(command);
            }
        }

        public void Undo()
        {
            if (_commands.Count == 0)
            {
                return;
            }

            _commands.RemoveAt(_commands.Count - 1);
        }

        public void Clear()
        {
            _commands.Clear();
        }
    }
}
