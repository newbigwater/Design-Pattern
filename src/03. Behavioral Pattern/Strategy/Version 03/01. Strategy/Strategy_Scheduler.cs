namespace _03.Behavioral_Pattern.Strategy.Version_03._01._Strategy
{
    public interface Strategy_Scheduler
    {
        string Name { get; }
        string GetNextCall();
        string SendCallToAgent();
    }
}
