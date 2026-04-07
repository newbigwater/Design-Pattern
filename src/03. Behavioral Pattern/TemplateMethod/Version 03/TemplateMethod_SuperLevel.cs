using System;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_03
{
    public class TemplateMethod_SuperLevel : TemplateMethod_PlayerLevel
    {
        public override string LevelName => "상급자";
        protected override bool CanJump => true;
        protected override bool CanTurn => true;

        protected override string RunCore()
        {
            string value = "순간 이동합니다.";
            Console.WriteLine(value);
            return value;
        }

        protected override string JumpCore()
        {
            string value = "높이 점프 합니다.";
            Console.WriteLine(value);
            return value;
        }

        protected override string TurnCore()
        {
            string value = "한 바퀴 돕니다.";
            Console.WriteLine(value);
            return value;
        }
    }
}
