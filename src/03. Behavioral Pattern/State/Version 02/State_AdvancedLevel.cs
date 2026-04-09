namespace _03.Behavioral_Pattern.State.Version_02
{
    public class State_AdvancedLevel : State_PlayerLevel
    {
        public override string Run()
        {
            return "빠르게 달립니다.";
        }

        public override string Jump()
        {
            return "점프 합니다.";
        }

        public override string Turn()
        {
            return "Turn - 할 수 없는 레벨입니다.";
        }

        public override string ShowLevelMessage()
        {
            return "***** 중급자 레벨 입니다. *****";
        }
    }
}
