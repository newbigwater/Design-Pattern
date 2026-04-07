namespace _03.Behavioral_Pattern.TemplateMethod.Version_02
{
    public sealed class TemplateMethod_PlayResult
    {
        public TemplateMethod_PlayResult(string levelMessage, string executionLog, int jumpCount)
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
