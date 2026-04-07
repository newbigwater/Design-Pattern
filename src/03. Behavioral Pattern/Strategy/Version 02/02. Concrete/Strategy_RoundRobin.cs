using _03.Behavioral_Pattern.Strategy.Version_02._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_02._02._Concrete
{
    public class Strategy_RoundRobin : Strategy_Scheduler
    {
        public string Name => "Round Robin";

        public string GetNextCall()
        {
            return "?곷떞 ?꾪솕瑜??쒖꽌?濡??湲곗뿴?먯꽌 媛?몄샃?덈떎.";
        }

        public string SendCallToAgent()
        {
            return "?ㅼ쓬 ?쒖꽌 ?곷떞?먯뿉寃?諛곕텇?⑸땲??";
        }
    }
}
