using System;

namespace _03.Behavioral_Pattern.Strategy
{
    public class Strategy_CallCenterScheduler_Ver1
    {
        public string Run(string schedulerType)
        {
            Strategy_Scheduler scheduler;

            switch (schedulerType)
            {
                case "RoundRobin":
                    scheduler = new Strategy_RoundRobin();
                    break;
                case "LeastJob":
                    scheduler = new Strategy_LeastJob();
                    break;
                case "PriorityAllocation":
                    scheduler = new Strategy_PriorityAllocation();
                    break;
                case "AgentGetCall":
                    scheduler = new Strategy_AgentGetCall();
                    break;
                default:
                    throw new ArgumentException("Unknown scheduler type.", nameof(schedulerType));
            }

            return $"{scheduler.Name} | {scheduler.GetNextCall()} | {scheduler.SendCallToAgent()}";
        }
    }
}
