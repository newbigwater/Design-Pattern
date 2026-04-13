using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChainOfResponsibilityVer1 = _03.Behavioral_Pattern.ChainOfResponsibility.Version_01;
using ChainOfResponsibilityVer2 = _03.Behavioral_Pattern.ChainOfResponsibility.Version_02;

namespace unitTest._03._Behavioral_Pattern
{
    partial class _03_Behavioral_Pattern
    {
        [TestMethod("[ChainOfResponsibility Ver1 Trouble ToString Uses Number]")]
        public void ChainOfResponsibility_Ver1_Trouble_ToString_Uses_Number()
        {
            var trouble = new ChainOfResponsibilityVer1.ChainOfResponsibility_Trouble(429);

            Assert.AreEqual("[Trouble 429]", trouble.ToString());
        }

        [TestMethod("[ChainOfResponsibility Ver1 NotSupport Fails Without Next]")]
        public void ChainOfResponsibility_Ver1_NotSupport_Fails_Without_Next()
        {
            var alice = new ChainOfResponsibilityVer1.ChainOfResponsibility_NotSupport("Alice");
            string output = CaptureSupportOutput(alice, 1);

            StringAssert.Contains(output, "[Trouble 1] cannot be resolved.");
        }

        [TestMethod("[ChainOfResponsibility Ver1 LimitSupport Resolves When Under Limit]")]
        public void ChainOfResponsibility_Ver1_LimitSupport_Resolves_When_Under_Limit()
        {
            var bob = new ChainOfResponsibilityVer1.ChainOfResponsibility_LimitSupport("Bob", 100);
            string output = CaptureSupportOutput(bob, 99);

            StringAssert.Contains(output, "[Trouble 99] is resolved by [Bob].");
        }

        [TestMethod("[ChainOfResponsibility Ver1 Scenario Produces Expected Chain Decisions]")]
        public void ChainOfResponsibility_Ver1_Scenario_Produces_Expected_Chain_Decisions()
        {
            var alice = new ChainOfResponsibilityVer1.ChainOfResponsibility_NotSupport("Alice");
            var bob = new ChainOfResponsibilityVer1.ChainOfResponsibility_LimitSupport("Bob", 100);
            var charlie = new ChainOfResponsibilityVer1.ChainOfResponsibility_SpecialSupport("Charlie", 429);
            var diana = new ChainOfResponsibilityVer1.ChainOfResponsibility_LimitSupport("Diana", 200);
            var elmo = new ChainOfResponsibilityVer1.ChainOfResponsibility_OddSupport("Elmo");
            var fred = new ChainOfResponsibilityVer1.ChainOfResponsibility_LimitSupport("Fred", 300);

            alice.SetNext(bob).SetNext(charlie).SetNext(diana).SetNext(elmo).SetNext(fred);

            string output = CaptureScenarioOutput(alice);
            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string[] expected =
            {
                "[Trouble 0] is resolved by [Bob].",
                "[Trouble 33] is resolved by [Bob].",
                "[Trouble 66] is resolved by [Bob].",
                "[Trouble 99] is resolved by [Bob].",
                "[Trouble 132] is resolved by [Diana].",
                "[Trouble 165] is resolved by [Diana].",
                "[Trouble 198] is resolved by [Diana].",
                "[Trouble 231] is resolved by [Elmo].",
                "[Trouble 264] is resolved by [Fred].",
                "[Trouble 297] is resolved by [Elmo].",
                "[Trouble 330] cannot be resolved.",
                "[Trouble 363] is resolved by [Elmo].",
                "[Trouble 396] cannot be resolved.",
                "[Trouble 429] is resolved by [Charlie].",
                "[Trouble 462] cannot be resolved.",
                "[Trouble 495] is resolved by [Elmo]."
            };

            CollectionAssert.AreEqual(expected, lines);
        }

        [TestMethod("[ChainOfResponsibility Ver2 Returns Result Object]")]
        public void ChainOfResponsibility_Ver2_Returns_Result_Object()
        {
            var bob = new ChainOfResponsibilityVer2.ChainOfResponsibility_LimitSupport("Bob", 100);
            var result = bob.SupportRequest(new ChainOfResponsibilityVer2.ChainOfResponsibility_Trouble(99));

            Assert.IsTrue(result.IsResolved);
            Assert.AreEqual("[Bob]", result.Resolver);
            Assert.AreEqual("[Trouble 99] is resolved by [Bob].", result.Message);
        }

        [TestMethod("[ChainOfResponsibility Ver2 Fails Without Next]")]
        public void ChainOfResponsibility_Ver2_Fails_Without_Next()
        {
            var alice = new ChainOfResponsibilityVer2.ChainOfResponsibility_NotSupport("Alice");
            var result = alice.SupportRequest(new ChainOfResponsibilityVer2.ChainOfResponsibility_Trouble(330));

            Assert.IsFalse(result.IsResolved);
            Assert.IsNull(result.Resolver);
            Assert.AreEqual("[Trouble 330] cannot be resolved.", result.Message);
        }

        [TestMethod("[ChainOfResponsibility Ver2 Throws On Null Trouble]")]
        public void ChainOfResponsibility_Ver2_Throws_On_Null_Trouble()
        {
            var alice = new ChainOfResponsibilityVer2.ChainOfResponsibility_NotSupport("Alice");

            Assert.ThrowsException<ArgumentNullException>(() => alice.SupportRequest(null));
        }

        [TestMethod("[ChainOfResponsibility Ver2 Throws On Null Next]")]
        public void ChainOfResponsibility_Ver2_Throws_On_Null_Next()
        {
            var alice = new ChainOfResponsibilityVer2.ChainOfResponsibility_NotSupport("Alice");

            Assert.ThrowsException<ArgumentNullException>(() => alice.SetNext(null));
        }

        [TestMethod("[ChainOfResponsibility Ver2 Throws On Negative Trouble Number]")]
        public void ChainOfResponsibility_Ver2_Throws_On_Negative_Trouble_Number()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ChainOfResponsibilityVer2.ChainOfResponsibility_Trouble(-1));
        }

        [TestMethod("[ChainOfResponsibility Ver2 Scenario Produces Expected Chain Decisions]")]
        public void ChainOfResponsibility_Ver2_Scenario_Produces_Expected_Chain_Decisions()
        {
            var alice = new ChainOfResponsibilityVer2.ChainOfResponsibility_NotSupport("Alice");
            var bob = new ChainOfResponsibilityVer2.ChainOfResponsibility_LimitSupport("Bob", 100);
            var charlie = new ChainOfResponsibilityVer2.ChainOfResponsibility_SpecialSupport("Charlie", 429);
            var diana = new ChainOfResponsibilityVer2.ChainOfResponsibility_LimitSupport("Diana", 200);
            var elmo = new ChainOfResponsibilityVer2.ChainOfResponsibility_OddSupport("Elmo");
            var fred = new ChainOfResponsibilityVer2.ChainOfResponsibility_LimitSupport("Fred", 300);

            alice.SetNext(bob).SetNext(charlie).SetNext(diana).SetNext(elmo).SetNext(fred);

            string[] actual = RunScenarioVer2(alice);
            string[] expected =
            {
                "[Trouble 0] is resolved by [Bob].",
                "[Trouble 33] is resolved by [Bob].",
                "[Trouble 66] is resolved by [Bob].",
                "[Trouble 99] is resolved by [Bob].",
                "[Trouble 132] is resolved by [Diana].",
                "[Trouble 165] is resolved by [Diana].",
                "[Trouble 198] is resolved by [Diana].",
                "[Trouble 231] is resolved by [Elmo].",
                "[Trouble 264] is resolved by [Fred].",
                "[Trouble 297] is resolved by [Elmo].",
                "[Trouble 330] cannot be resolved.",
                "[Trouble 363] is resolved by [Elmo].",
                "[Trouble 396] cannot be resolved.",
                "[Trouble 429] is resolved by [Charlie].",
                "[Trouble 462] cannot be resolved.",
                "[Trouble 495] is resolved by [Elmo]."
            };

            CollectionAssert.AreEqual(expected, actual);
        }

        private static string CaptureSupportOutput(ChainOfResponsibilityVer1.ChainOfResponsibility_Support support, int troubleNumber)
        {
            var writer = new StringWriter();
            TextWriter original = Console.Out;

            try
            {
                Console.SetOut(writer);
                support.SupportRequest(new ChainOfResponsibilityVer1.ChainOfResponsibility_Trouble(troubleNumber));
                return writer.ToString();
            }
            finally
            {
                Console.SetOut(original);
            }
        }

        private static string CaptureScenarioOutput(ChainOfResponsibilityVer1.ChainOfResponsibility_Support support)
        {
            var writer = new StringWriter();
            TextWriter original = Console.Out;

            try
            {
                Console.SetOut(writer);

                for (int i = 0; i < 500; i += 33)
                {
                    support.SupportRequest(new ChainOfResponsibilityVer1.ChainOfResponsibility_Trouble(i));
                }

                return writer.ToString();
            }
            finally
            {
                Console.SetOut(original);
            }
        }

        private static string[] RunScenarioVer2(ChainOfResponsibilityVer2.ChainOfResponsibility_Support support)
        {
            var messages = new string[16];
            int index = 0;

            for (int i = 0; i < 500; i += 33)
            {
                var result = support.SupportRequest(new ChainOfResponsibilityVer2.ChainOfResponsibility_Trouble(i));
                messages[index++] = result.Message;
            }

            return messages;
        }
    }
}
