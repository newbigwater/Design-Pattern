using System;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_02
{
    public class TemplateMethod_BeginnerLevel : TemplateMethod_PlayerLevel
    {
        public override string Run()
        {
            string value = "천천히 달립니다.";
            Console.WriteLine(value);
            return value;
        }

        public override string Jump()
        {
            string value = "Jump - 할 수 없는 레벨입니다.";
            Console.WriteLine(value);
            return value;
        }

        public override string Turn()
        {
            string value = "Turn - 할 수 없는 레벨입니다.";
            Console.WriteLine(value);
            return value;
        }

        public override string ShowLevelMessage()
        {
            string value = "***** 초보자 레벨 입니다. *****";
            Console.WriteLine(value);
            return value;
        }
    }
}
