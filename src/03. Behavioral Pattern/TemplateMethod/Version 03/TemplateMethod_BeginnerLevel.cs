using System;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_03
{
    public class TemplateMethod_BeginnerLevel : TemplateMethod_PlayerLevel
    {
        public override string LevelName => "초보자";

        protected override string RunCore()
        {
            string value = "천천히 달립니다.";
            Console.WriteLine(value);
            return value;
        }
    }
}
