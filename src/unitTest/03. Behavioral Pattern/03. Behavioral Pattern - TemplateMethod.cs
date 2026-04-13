using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateMethodVer1 = _03.Behavioral_Pattern.TemplateMethod.Version_01;
using TemplateMethodVer2 = _03.Behavioral_Pattern.TemplateMethod.Version_02;
using TemplateMethodVer3 = _03.Behavioral_Pattern.TemplateMethod.Version_03;

namespace unitTest._03._Behavioral_Pattern
{
    partial class _03_Behavioral_Pattern
    {
        [TestMethod("[TemplateMethod Ver1 Beginner Uses Baseline Sequence]")]
        public void TemplateMethod_Ver1_Beginner_Uses_Baseline_Sequence()
        {
            var level = new TemplateMethodVer1.TemplateMethod_BeginnerLevel();

            string result = level.Go(2);

            StringAssert.Contains(result, "천천히 달립니다.");
            StringAssert.Contains(result, "Jump - 할 수 없는 레벨입니다.");
            StringAssert.Contains(result, "Turn - 할 수 없는 레벨입니다.");
        }

        [TestMethod("[TemplateMethod Ver2 Returns Structured Result]")]
        public void TemplateMethod_Ver2_Returns_Structured_Result()
        {
            var player = new TemplateMethodVer2.TemplateMethod_Player();

            TemplateMethodVer2.TemplateMethod_PlayResult result = player.Play(1);

            StringAssert.Contains(result.LevelMessage, "초보자");
            StringAssert.Contains(result.ExecutionLog, "천천히 달립니다.");
            Assert.AreEqual(1, result.JumpCount);
        }

        [TestMethod("[TemplateMethod Ver2 UpgradeLevel Throws On Null]")]
        public void TemplateMethod_Ver2_UpgradeLevel_Throws_On_Null()
        {
            var player = new TemplateMethodVer2.TemplateMethod_Player();

            Assert.ThrowsException<System.ArgumentNullException>(() => player.UpgradeLevel(null));
        }

        [TestMethod("[TemplateMethod Ver3 Advanced Uses Jump Hook]")]
        public void TemplateMethod_Ver3_Advanced_Uses_Jump_Hook()
        {
            var player = new TemplateMethodVer3.TemplateMethod_Player();
            player.UpgradeLevel(new TemplateMethodVer3.TemplateMethod_AdvancedLevel());

            TemplateMethodVer3.TemplateMethod_PlayResult result = player.Play(2);

            StringAssert.Contains(result.LevelMessage, "중급자");
            StringAssert.Contains(result.ExecutionLog, "빠르게 달립니다.");
            StringAssert.Contains(result.ExecutionLog, "점프 합니다.");
            StringAssert.Contains(result.ExecutionLog, "Turn - 할 수 없는 레벨입니다.");
        }

        [TestMethod("[TemplateMethod Ver3 Super Uses Turn Hook]")]
        public void TemplateMethod_Ver3_Super_Uses_Turn_Hook()
        {
            var player = new TemplateMethodVer3.TemplateMethod_Player();
            player.UpgradeLevel(new TemplateMethodVer3.TemplateMethod_SuperLevel());

            TemplateMethodVer3.TemplateMethod_PlayResult result = player.Play(1);

            StringAssert.Contains(result.LevelMessage, "상급자");
            StringAssert.Contains(result.ExecutionLog, "높이 점프 합니다.");
            StringAssert.Contains(result.ExecutionLog, "한 바퀴 돕니다.");
        }

        [TestMethod("[TemplateMethod Ver3 Throws On Negative Jump Count]")]
        public void TemplateMethod_Ver3_Throws_On_Negative_Jump_Count()
        {
            var player = new TemplateMethodVer3.TemplateMethod_Player();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => player.Play(-1));
        }

        [TestMethod("[TemplateMethod Ver3 Scenario Upgrades Level In Sequence]")]
        public void TemplateMethod_Ver3_Scenario_Upgrades_Level_In_Sequence()
        {
            var player = new TemplateMethodVer3.TemplateMethod_Player();

            TemplateMethodVer3.TemplateMethod_PlayResult beginner = player.Play(1);
            string advancedMessage = player.UpgradeLevel(new TemplateMethodVer3.TemplateMethod_AdvancedLevel());
            TemplateMethodVer3.TemplateMethod_PlayResult advanced = player.Play(2);
            string superMessage = player.UpgradeLevel(new TemplateMethodVer3.TemplateMethod_SuperLevel());
            TemplateMethodVer3.TemplateMethod_PlayResult super = player.Play(3);

            Assert.AreEqual(1, beginner.JumpCount);
            Assert.AreEqual(2, advanced.JumpCount);
            Assert.AreEqual(3, super.JumpCount);
            Assert.IsFalse(string.IsNullOrWhiteSpace(advancedMessage));
            Assert.IsFalse(string.IsNullOrWhiteSpace(superMessage));
            Assert.IsInstanceOfType(player.Level, typeof(TemplateMethodVer3.TemplateMethod_SuperLevel));
        }
    }
}
