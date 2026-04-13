using System;
using System.Collections.Generic;

namespace _03.Behavioral_Pattern.Command.Version_02
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
            for (int i = 0; i < _commands.Count; i++)
            {
                _commands[i].Execute();
            }
        }

        public void Append(Command_Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            if (ReferenceEquals(command, this))
            {
                throw new ArgumentException("Macro command cannot append itself.", nameof(command));
            }

            _commands.Add(command);
        }

        public bool Undo()
        {
            if (_commands.Count == 0)
            {
                return false;
            }

            _commands.RemoveAt(_commands.Count - 1);
            return true;
        }

        public void Clear()
        {
            _commands.Clear();
        }
    }
}
