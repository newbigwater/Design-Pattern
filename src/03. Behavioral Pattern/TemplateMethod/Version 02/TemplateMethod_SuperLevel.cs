using System;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_02
{
    public class TemplateMethod_SuperLevel : TemplateMethod_PlayerLevel
    {
        public override string Run()
        {
            string value = "순간 이동합니다.";
            Console.WriteLine(value);
            return value;
        }

        public override string Jump()
        {
            string value = "높이 점프 합니다.";
            Console.WriteLine(value);
            return value;
        }

        public override string Turn()
        {
            string value = "한 바퀴 돕니다.";
            Console.WriteLine(value);
            return value;
        }

        public override string ShowLevelMessage()
        {
            string value = "***** 상급자 레벨 입니다. *****";
            Console.WriteLine(value);
            return value;
        }
    }
}
