using System;
using System.Text;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_02
{
    public abstract class TemplateMethod_PlayerLevel
    {
        public abstract string ShowLevelMessage();
        public abstract string Run();
        public abstract string Jump();
        public abstract string Turn();

        public TemplateMethod_PlayResult Go(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            var levelMessage = ShowLevelMessage();
            var sb = new StringBuilder();
            sb.AppendLine(Run());

            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(Jump());
            }

            sb.AppendLine(Turn());

            return new TemplateMethod_PlayResult(levelMessage, sb.ToString(), count);
        }
    }
}
