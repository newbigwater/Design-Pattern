using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyVer1Concrete = _03.Behavioral_Pattern.Strategy.Version_01._02._Concrete;
using StrategyVer1Context = _03.Behavioral_Pattern.Strategy.Version_01._03._Context;
using StrategyVer2Concrete = _03.Behavioral_Pattern.Strategy.Version_02._02._Concrete;
using StrategyVer2Context = _03.Behavioral_Pattern.Strategy.Version_02._03._Context;
using StrategyVer3Concrete = _03.Behavioral_Pattern.Strategy.Version_03._02._Concrete;
using StrategyVer3Context = _03.Behavioral_Pattern.Strategy.Version_03._03._Context;
using StrategyVer3Result = _03.Behavioral_Pattern.Strategy.Version_03._04._Result;

namespace unitTest._03._Behavioral_Pattern
{
    partial class _03_Behavioral_Pattern
    {
        [TestMethod("[Strategy Ver1 Uses Hard Coded Round Robin]")]
        public void Strategy_Ver1_Uses_Hard_Coded_Round_Robin()
        {
            StrategyVer1Context.Strategy_CallCenterScheduler_Ver1 scheduler = new StrategyVer1Context.Strategy_CallCenterScheduler_Ver1();
            StrategyVer1Concrete.Strategy_RoundRobin roundRobin = new StrategyVer1Concrete.Strategy_RoundRobin();

            string result = scheduler.Run("RoundRobin");

            StringAssert.Contains(result, roundRobin.Name);
            StringAssert.Contains(result, roundRobin.GetNextCall());
            StringAssert.Contains(result, roundRobin.SendCallToAgent());
        }

        [TestMethod("[Strategy Ver1 Throws On Unknown Type]")]
        public void Strategy_Ver1_Throws_On_Unknown_Type()
        {
            StrategyVer1Context.Strategy_CallCenterScheduler_Ver1 scheduler = new StrategyVer1Context.Strategy_CallCenterScheduler_Ver1();

            Assert.ThrowsException<System.ArgumentException>(() => scheduler.Run("Unknown"));
        }

        [TestMethod("[Strategy Ver2 Uses Injected Strategy]")]
        public void Strategy_Ver2_Uses_Injected_Strategy()
        {
            StrategyVer2Concrete.Strategy_PriorityAllocation strategy = new StrategyVer2Concrete.Strategy_PriorityAllocation();
            StrategyVer2Context.Strategy_CallCenterScheduler_Ver2 scheduler =
                new StrategyVer2Context.Strategy_CallCenterScheduler_Ver2(strategy);

            string result = scheduler.Run();

            StringAssert.Contains(result, strategy.Name);
            StringAssert.Contains(result, strategy.GetNextCall());
        }

        [TestMethod("[Strategy Ver2 Can Use Another Strategy]")]
        public void Strategy_Ver2_Can_Use_Another_Strategy()
        {
            StrategyVer2Concrete.Strategy_LeastJob strategy = new StrategyVer2Concrete.Strategy_LeastJob();
            StrategyVer2Context.Strategy_CallCenterScheduler_Ver2 scheduler =
                new StrategyVer2Context.Strategy_CallCenterScheduler_Ver2(strategy);

            string result = scheduler.Run();

            StringAssert.Contains(result, strategy.Name);
            StringAssert.Contains(result, strategy.SendCallToAgent());
        }

        [TestMethod("[Strategy Ver3 Exposes Current Strategy]")]
        public void Strategy_Ver3_Exposes_Current_Strategy()
        {
            StrategyVer3Context.Strategy_CallCenterScheduler_Ver3 scheduler =
                new StrategyVer3Context.Strategy_CallCenterScheduler_Ver3(new StrategyVer3Concrete.Strategy_RoundRobin());

            Assert.AreEqual("Round Robin", scheduler.CurrentStrategyName);
        }

        [TestMethod("[Strategy Ver3 Can Change Strategy]")]
        public void Strategy_Ver3_Can_Change_Strategy()
        {
            StrategyVer3Context.Strategy_CallCenterScheduler_Ver3 scheduler =
                new StrategyVer3Context.Strategy_CallCenterScheduler_Ver3(new StrategyVer3Concrete.Strategy_RoundRobin());

            scheduler.SetScheduler(new StrategyVer3Concrete.Strategy_AgentGetCall());

            Assert.AreEqual("Agent Get Call", scheduler.CurrentStrategyName);
        }

        [TestMethod("[Strategy Ver3 Returns Structured Result]")]
        public void Strategy_Ver3_Returns_Structured_Result()
        {
            StrategyVer3Concrete.Strategy_AgentGetCall strategy = new StrategyVer3Concrete.Strategy_AgentGetCall();
            StrategyVer3Context.Strategy_CallCenterScheduler_Ver3 scheduler =
                new StrategyVer3Context.Strategy_CallCenterScheduler_Ver3(strategy);

            StrategyVer3Result.Strategy_ScheduleResult_Ver3 result = scheduler.Run();

            Assert.AreEqual(strategy.Name, result.StrategyName);
            Assert.AreEqual(strategy.GetNextCall(), result.NextCallMessage);
            Assert.AreEqual(strategy.SendCallToAgent(), result.AllocationMessage);
        }
    }
}
