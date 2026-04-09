namespace _03.Behavioral_Pattern.State.Version_02
{
    public class State_SuperLevel : State_PlayerLevel
    {
        public override string Run()
        {
            return "순간 이동합니다.";
        }

        public override string Jump()
        {
            return "높이 점프 합니다.";
        }

        public override string Turn()
        {
            return "한 바퀴 돕니다.";
        }

        public override string ShowLevelMessage()
        {
            return "***** 상급자 레벨 입니다. *****";
        }
    }
}
