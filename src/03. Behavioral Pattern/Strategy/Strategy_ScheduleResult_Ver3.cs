namespace _03.Behavioral_Pattern.Strategy
{
    public sealed class Strategy_ScheduleResult_Ver3
    {
        public Strategy_ScheduleResult_Ver3(string strategyName, string nextCallMessage, string allocationMessage)
        {
            StrategyName = strategyName;
            NextCallMessage = nextCallMessage;
            AllocationMessage = allocationMessage;
        }

        public string StrategyName { get; }
        public string NextCallMessage { get; }
        public string AllocationMessage { get; }
    }
}
