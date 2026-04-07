using _03.Behavioral_Pattern.Strategy.Version_02._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_02._02._Concrete
{
    public class Strategy_AgentGetCall : Strategy_Scheduler
    {
        public string Name => "Agent Get Call";

        public string GetNextCall()
        {
            return "?곷떞?먯씠 ?ㅼ쓬 ?꾪솕 ?붿껌";
        }

        public string SendCallToAgent()
        {
            return "?곷떞?먯씠 ?꾪솕 ?곷떞??媛?멸컮?듬땲??";
        }
    }
}
