namespace _03.Behavioral_Pattern.State.Version_02
{
    public sealed class State_PlayResult
    {
        public State_PlayResult(string levelMessage, string executionLog, int jumpCount)
        {
            LevelMessage = levelMessage;
            ExecutionLog = executionLog;
            JumpCount = jumpCount;
        }

        public string LevelMessage { get; }
        public string ExecutionLog { get; }
        public int JumpCount { get; }
    }
}
