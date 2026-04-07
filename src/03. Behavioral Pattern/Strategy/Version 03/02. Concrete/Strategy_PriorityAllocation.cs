using _03.Behavioral_Pattern.Strategy.Version_03._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_03._02._Concrete
{
    public class Strategy_PriorityAllocation : Strategy_Scheduler
    {
        public string Name => "Priority Allocation";

        public string GetNextCall()
        {
            return "怨좉컼 ?깃툒???믪? 怨좉컼???꾪솕瑜?癒쇱? 媛?몄샃?덈떎.";
        }

        public string SendCallToAgent()
        {
            return "?낅Т skill 媛믪씠 ?믪? ?곷떞?먯뿉寃??곗꽑?곸쑝濡?諛곕텇?⑸땲??";
        }
    }
}
