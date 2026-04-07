using System;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_02
{
    public class TemplateMethod_Player
    {
        private TemplateMethod_PlayerLevel _level;

        public TemplateMethod_Player()
        {
            _level = new TemplateMethod_BeginnerLevel();
        }

        public TemplateMethod_PlayerLevel Level => _level;

        public string UpgradeLevel(TemplateMethod_PlayerLevel level)
        {
            if (level == null)
            {
                throw new ArgumentNullException(nameof(level));
            }

            _level = level;
            return _level.ShowLevelMessage();
        }

        public TemplateMethod_PlayResult Play(int count)
        {
            return _level.Go(count);
        }
    }
}
