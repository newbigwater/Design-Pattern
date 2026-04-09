namespace _03.Behavioral_Pattern.State.Version_02
{
    public class State_BeginnerLevel : State_PlayerLevel
    {
        public override string Run()
        {
            return "천천히 달립니다.";
        }

        public override string Jump()
        {
            return "Jump - 할 수 없는 레벨입니다.";
        }

        public override string Turn()
        {
            return "Turn - 할 수 없는 레벨입니다.";
        }

        public override string ShowLevelMessage()
        {
            return "***** 초보자 레벨 입니다. *****";
        }
    }
}
