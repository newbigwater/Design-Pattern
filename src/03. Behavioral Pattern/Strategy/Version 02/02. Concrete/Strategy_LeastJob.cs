using _03.Behavioral_Pattern.Strategy.Version_02._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_02._02._Concrete
{
    public class Strategy_LeastJob : Strategy_Scheduler
    {
        public string Name => "Least Job";

        public string GetNextCall()
        {
            return "?곷떞 ?꾪솕瑜??쒖꽌?濡??湲곗뿴?먯꽌 媛?몄샃?덈떎.";
        }

        public string SendCallToAgent()
        {
            return "?꾩옱 ?곷떞?낅Т媛 ?녾굅???곷떞 ?湲곌? 媛???곸? ?곷떞?먯뿉寃??좊떦?⑸땲??";
        }
    }
}
