using System;

namespace _03.Behavioral_Pattern.Strategy
{
    public sealed class Strategy_CallCenterScheduler_Ver3
    {
        public Strategy_CallCenterScheduler_Ver3(Strategy_Scheduler scheduler)
        {
            SetScheduler(scheduler);
        }

        public string CurrentStrategyName => _scheduler.Name;

        private Strategy_Scheduler _scheduler;

        public void SetScheduler(Strategy_Scheduler scheduler)
        {
            _scheduler = scheduler ?? throw new ArgumentNullException(nameof(scheduler));
        }

        public Strategy_ScheduleResult_Ver3 Run()
        {
            return new Strategy_ScheduleResult_Ver3(
                _scheduler.Name,
                _scheduler.GetNextCall(),
                _scheduler.SendCallToAgent());
        }
    }
}
