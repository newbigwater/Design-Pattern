using System;

namespace _03.Behavioral_Pattern.State.Version_02
{
    public class State_Player
    {
        private State_PlayerLevel _level;

        public State_Player()
        {
            _level = new State_BeginnerLevel();
        }

        public State_PlayerLevel Level => _level;

        public string UpgradeLevel(State_PlayerLevel level)
        {
            if (level == null)
            {
                throw new ArgumentNullException(nameof(level));
            }

            _level = level;
            return _level.ShowLevelMessage();
        }

        public State_PlayResult Play(int count)
        {
            return _level.Execute(count);
        }
    }
}
