namespace _03.Behavioral_Pattern.Strategy
{
    public class Strategy_CallCenterScheduler_Ver2
    {
        private readonly Strategy_Scheduler _scheduler;

        public Strategy_CallCenterScheduler_Ver2(Strategy_Scheduler scheduler)
        {
            _scheduler = scheduler ?? throw new System.ArgumentNullException(nameof(scheduler));
        }

        public string Run()
        {
            return $"{_scheduler.Name} | {_scheduler.GetNextCall()} | {_scheduler.SendCallToAgent()}";
        }
    }
}
