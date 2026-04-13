using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandVer1 = _03.Behavioral_Pattern.Command.Version_01;
using CommandVer2 = _03.Behavioral_Pattern.Command.Version_02;

namespace unitTest._03._Behavioral_Pattern
{
    partial class _03_Behavioral_Pattern
    {
        [TestMethod("[Command Ver1 DrawCommand Executes Drawable]")]
        public void Command_Ver1_DrawCommand_Executes_Drawable()
        {
            var history = new CommandVer1.Command_MacroCommand();
            var canvas = new CommandVer1.Command_DrawCanvas(400, 400, history);
            var command = new CommandVer1.Command_DrawCommand(canvas, new CommandVer1.Command_Point(10, 20));

            command.Execute();

            CommandVer1.Command_Point[] points = canvas.GetDrawnPoints();
            Assert.AreEqual(1, points.Length);
            Assert.AreEqual(10, points[0].X);
            Assert.AreEqual(20, points[0].Y);
        }

        [TestMethod("[Command Ver1 Undo Removes Last Command On Replay]")]
        public void Command_Ver1_Undo_Removes_Last_Command_On_Replay()
        {
            var history = new CommandVer1.Command_MacroCommand();
            var canvas = new CommandVer1.Command_DrawCanvas(400, 400, history);

            history.Append(new CommandVer1.Command_DrawCommand(canvas, new CommandVer1.Command_Point(10, 10)));
            history.Append(new CommandVer1.Command_DrawCommand(canvas, new CommandVer1.Command_Point(20, 20)));
            history.Append(new CommandVer1.Command_DrawCommand(canvas, new CommandVer1.Command_Point(30, 30)));

            history.Undo();
            canvas.Paint();

            CommandVer1.Command_Point[] points = canvas.GetDrawnPoints();
            Assert.AreEqual(2, points.Length);
            Assert.AreEqual(10, points[0].X);
            Assert.AreEqual(20, points[1].X);
        }

        [TestMethod("[Command Ver1 Scenario Replays Drag History And Clear]")]
        public void Command_Ver1_Scenario_Replays_Drag_History_And_Clear()
        {
            var app = new CommandVer1.Command_Main(400, 400);

            app.MouseDragged(10, 10);
            app.MouseDragged(20, 20);
            app.MouseDragged(30, 30);

            AssertPointSequenceVer1(app.Canvas.GetDrawnPoints(), new[] { 10, 20, 30 }, new[] { 10, 20, 30 });
            Assert.AreEqual(3, app.History.Count);

            app.ClickClearButton();

            Assert.AreEqual(0, app.History.Count);
            Assert.AreEqual(0, app.Canvas.GetDrawnPoints().Length);

            app.MouseDragged(40, 40);
            app.MouseDragged(50, 50);
            app.Canvas.Paint();

            AssertPointSequenceVer1(app.Canvas.GetDrawnPoints(), new[] { 40, 50 }, new[] { 40, 50 });
        }

        [TestMethod("[Command Ver2 Throws On Null Command Append]")]
        public void Command_Ver2_Throws_On_Null_Command_Append()
        {
            var history = new CommandVer2.Command_MacroCommand();

            Assert.ThrowsException<ArgumentNullException>(() => history.Append(null));
        }

        [TestMethod("[Command Ver2 Throws On Self Append]")]
        public void Command_Ver2_Throws_On_Self_Append()
        {
            var history = new CommandVer2.Command_MacroCommand();

            Assert.ThrowsException<ArgumentException>(() => history.Append(history));
        }

        [TestMethod("[Command Ver2 Throws On Out Of Range Drag]")]
        public void Command_Ver2_Throws_On_Out_Of_Range_Drag()
        {
            var app = new CommandVer2.Command_Main(100, 100);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => app.MouseDragged(100, 10));
        }

        [TestMethod("[Command Ver2 Scenario Replays Drag History And Clear]")]
        public void Command_Ver2_Scenario_Replays_Drag_History_And_Clear()
        {
            var app = new CommandVer2.Command_Main(400, 400);

            app.MouseDragged(10, 10);
            app.MouseDragged(20, 20);
            app.MouseDragged(30, 30);

            AssertPointSequenceVer2(app.Repaint().Points, new[] { 10, 20, 30 }, new[] { 10, 20, 30 });
            Assert.AreEqual(3, app.History.Count);

            CommandVer2.Command_DrawSnapshot cleared = app.ClickClearButton();
            Assert.AreEqual(0, cleared.Count);
            Assert.AreEqual(0, app.History.Count);

            app.MouseDragged(40, 40);
            app.MouseDragged(50, 50);

            AssertPointSequenceVer2(app.Repaint().Points, new[] { 40, 50 }, new[] { 40, 50 });
        }

        private static void AssertPointSequenceVer1(CommandVer1.Command_Point[] points, int[] expectedX, int[] expectedY)
        {
            Assert.AreEqual(expectedX.Length, points.Length);

            for (int i = 0; i < points.Length; i++)
            {
                Assert.AreEqual(expectedX[i], points[i].X);
                Assert.AreEqual(expectedY[i], points[i].Y);
            }
        }

        private static void AssertPointSequenceVer2(CommandVer2.Command_Point[] points, int[] expectedX, int[] expectedY)
        {
            Assert.AreEqual(expectedX.Length, points.Length);

            for (int i = 0; i < points.Length; i++)
            {
                Assert.AreEqual(expectedX[i], points[i].X);
                Assert.AreEqual(expectedY[i], points[i].Y);
            }
        }
    }
}
