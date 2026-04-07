using System;
using System.Text;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_03
{
    public abstract class TemplateMethod_PlayerLevel
    {
        public abstract string LevelName { get; }

        protected abstract string RunCore();
        protected virtual bool CanJump => false;
        protected virtual bool CanTurn => false;

        protected virtual string JumpCore()
        {
            return "Jump - 할 수 없는 레벨입니다.";
        }

        protected virtual string TurnCore()
        {
            return "Turn - 할 수 없는 레벨입니다.";
        }

        public string ShowLevelMessage()
        {
            var value = $"***** {LevelName} 레벨 입니다. *****";
            Console.WriteLine(value);
            return value;
        }

        public TemplateMethod_PlayResult Go(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            var sb = new StringBuilder();
            sb.AppendLine(RunCore());

            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(CanJump ? JumpCore() : "Jump - 할 수 없는 레벨입니다.");
            }

            sb.AppendLine(CanTurn ? TurnCore() : "Turn - 할 수 없는 레벨입니다.");

            return new TemplateMethod_PlayResult(ShowLevelMessage(), sb.ToString(), count);
        }
    }
}
