using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03.Behavioral_Pattern.Strategy;

namespace unitTest._03._Behavioral_Pattern
{
    partial class _03_Behavioral_Pattern
    {
        [TestMethod("[Strategy Ver1 Uses Hard Coded Round Robin]")]
        public void Strategy_Ver1_Uses_Hard_Coded_Round_Robin()
        {
            Strategy_CallCenterScheduler_Ver1 scheduler = new Strategy_CallCenterScheduler_Ver1();
            Strategy_RoundRobin roundRobin = new Strategy_RoundRobin();

            string result = scheduler.Run("RoundRobin");

            StringAssert.Contains(result, roundRobin.Name);
            StringAssert.Contains(result, roundRobin.GetNextCall());
            StringAssert.Contains(result, roundRobin.SendCallToAgent());
        }

        [TestMethod("[Strategy Ver1 Throws On Unknown Type]")]
        public void Strategy_Ver1_Throws_On_Unknown_Type()
        {
            Strategy_CallCenterScheduler_Ver1 scheduler = new Strategy_CallCenterScheduler_Ver1();

            Assert.ThrowsException<System.ArgumentException>(() => scheduler.Run("Unknown"));
        }

        [TestMethod("[Strategy Ver2 Uses Injected Strategy]")]
        public void Strategy_Ver2_Uses_Injected_Strategy()
        {
            Strategy_PriorityAllocation strategy = new Strategy_PriorityAllocation();
            Strategy_CallCenterScheduler_Ver2 scheduler =
                new Strategy_CallCenterScheduler_Ver2(strategy);

            string result = scheduler.Run();

            StringAssert.Contains(result, strategy.Name);
            StringAssert.Contains(result, strategy.GetNextCall());
        }

        [TestMethod("[Strategy Ver2 Can Use Another Strategy]")]
        public void Strategy_Ver2_Can_Use_Another_Strategy()
        {
            Strategy_LeastJob strategy = new Strategy_LeastJob();
            Strategy_CallCenterScheduler_Ver2 scheduler =
                new Strategy_CallCenterScheduler_Ver2(strategy);

            string result = scheduler.Run();

            StringAssert.Contains(result, strategy.Name);
            StringAssert.Contains(result, strategy.SendCallToAgent());
        }

        [TestMethod("[Strategy Ver3 Exposes Current Strategy]")]
        public void Strategy_Ver3_Exposes_Current_Strategy()
        {
            Strategy_CallCenterScheduler_Ver3 scheduler =
                new Strategy_CallCenterScheduler_Ver3(new Strategy_RoundRobin());

            Assert.AreEqual("Round Robin", scheduler.CurrentStrategyName);
        }

        [TestMethod("[Strategy Ver3 Can Change Strategy]")]
        public void Strategy_Ver3_Can_Change_Strategy()
        {
            Strategy_CallCenterScheduler_Ver3 scheduler =
                new Strategy_CallCenterScheduler_Ver3(new Strategy_RoundRobin());

            scheduler.SetScheduler(new Strategy_AgentGetCall());

            Assert.AreEqual("Agent Get Call", scheduler.CurrentStrategyName);
        }

        [TestMethod("[Strategy Ver3 Returns Structured Result]")]
        public void Strategy_Ver3_Returns_Structured_Result()
        {
            Strategy_AgentGetCall strategy = new Strategy_AgentGetCall();
            Strategy_CallCenterScheduler_Ver3 scheduler =
                new Strategy_CallCenterScheduler_Ver3(strategy);

            Strategy_ScheduleResult_Ver3 result = scheduler.Run();

            Assert.AreEqual(strategy.Name, result.StrategyName);
            Assert.AreEqual(strategy.GetNextCall(), result.NextCallMessage);
            Assert.AreEqual(strategy.SendCallToAgent(), result.AllocationMessage);
        }
    }
}
