using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateVer1 = _03.Behavioral_Pattern.State.Version_01;
using StateVer2 = _03.Behavioral_Pattern.State.Version_02;

namespace unitTest._03._Behavioral_Pattern
{
    partial class _03_Behavioral_Pattern
    {
        [TestMethod("[State Ver1 Default Level Is Beginner]")]
        public void State_Ver1_Default_Level_Is_Beginner()
        {
            var player = new StateVer1.State_Player();

            Assert.IsInstanceOfType(player.Level, typeof(StateVer1.State_BeginnerLevel));
        }

        [TestMethod("[State Ver1 Beginner Cannot Jump]")]
        public void State_Ver1_Beginner_Cannot_Jump()
        {
            var player = new StateVer1.State_Player();

            string result = player.Play(1);

            StringAssert.Contains(result, "Jump - 할 수 없는 레벨입니다.");
        }

        [TestMethod("[State Ver2 Play Returns Structured Result]")]
        public void State_Ver2_Play_Returns_Structured_Result()
        {
            var player = new StateVer2.State_Player();

            StateVer2.State_PlayResult result = player.Play(2);

            StringAssert.Contains(result.LevelMessage, "초보자");
            StringAssert.Contains(result.ExecutionLog, "천천히 달립니다.");
            Assert.AreEqual(2, result.JumpCount);
        }

        [TestMethod("[State Ver2 UpgradeLevel Throws On Null]")]
        public void State_Ver2_UpgradeLevel_Throws_On_Null()
        {
            var player = new StateVer2.State_Player();

            Assert.ThrowsException<System.ArgumentNullException>(() => player.UpgradeLevel(null));
        }

        [TestMethod("[State Ver2 Throws On Negative Jump Count]")]
        public void State_Ver2_Throws_On_Negative_Jump_Count()
        {
            var player = new StateVer2.State_Player();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => player.Play(-1));
        }

        [TestMethod("[State Ver2 Scenario Upgrades Level In Sequence]")]
        public void State_Ver2_Scenario_Upgrades_Level_In_Sequence()
        {
            var player = new StateVer2.State_Player();

            StateVer2.State_PlayResult beginner = player.Play(1);
            string advancedMessage = player.UpgradeLevel(new StateVer2.State_AdvancedLevel());
            StateVer2.State_PlayResult advanced = player.Play(2);
            string superMessage = player.UpgradeLevel(new StateVer2.State_SuperLevel());
            StateVer2.State_PlayResult super = player.Play(3);

            Assert.AreEqual(1, beginner.JumpCount);
            Assert.AreEqual(2, advanced.JumpCount);
            Assert.AreEqual(3, super.JumpCount);
            Assert.IsFalse(string.IsNullOrWhiteSpace(advancedMessage));
            Assert.IsFalse(string.IsNullOrWhiteSpace(superMessage));
            Assert.IsInstanceOfType(player.Level, typeof(StateVer2.State_SuperLevel));
        }
    }
}
