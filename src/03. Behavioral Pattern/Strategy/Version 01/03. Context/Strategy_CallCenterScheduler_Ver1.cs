using System;
using _03.Behavioral_Pattern.Strategy.Version_01._01._Strategy;
using _03.Behavioral_Pattern.Strategy.Version_01._02._Concrete;

namespace _03.Behavioral_Pattern.Strategy.Version_01._03._Context
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
