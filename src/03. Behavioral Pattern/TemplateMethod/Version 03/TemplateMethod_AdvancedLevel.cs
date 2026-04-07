using System;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_03
{
    public class TemplateMethod_AdvancedLevel : TemplateMethod_PlayerLevel
    {
        public override string LevelName => "중급자";
        protected override bool CanJump => true;

        protected override string RunCore()
        {
            string value = "빠르게 달립니다.";
            Console.WriteLine(value);
            return value;
        }

        protected override string JumpCore()
        {
            string value = "점프 합니다.";
            Console.WriteLine(value);
            return value;
        }
    }
}
