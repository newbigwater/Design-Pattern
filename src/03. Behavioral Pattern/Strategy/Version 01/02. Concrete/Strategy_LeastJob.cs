using _03.Behavioral_Pattern.Strategy.Version_01._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_01._02._Concrete
{
    public class Strategy_LeastJob : Strategy_Scheduler
    {
        #region ?? Event Handle             ?

        #endregion // Event Handle

        #region ?? Fields                   ?

        #endregion // Fields

        #region ?? Properties               ?

        public string Name => "Least Job";

        #endregion // Properties

        ////////////////////////////////////////

        #region ?? Constructor              ?

        #endregion // Constructor

        ////////////////////////////////////////

        #region ?? Override                 ?

        #region ?? Override : Predicate     ?

        #endregion // Override : Predicate

        #region ?? Override : Event Handler ?

        #endregion // Override : Event Handler

        #region ?? Override : Function      ?

        public string GetNextCall()
        {
            return "?곷떞 ?꾪솕瑜??쒖꽌?濡??湲곗뿴?먯꽌 媛?몄샃?덈떎.";
        }

        public string SendCallToAgent()
        {
            return "?꾩옱 ?곷떞?낅Т媛 ?녾굅???곷떞 ?湲곌? 媛???곸? ?곷떞?먯뿉寃??좊떦?⑸땲??";
        }

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ?? Method                   ?

        #region ?? Method : Predicate       ?

        #endregion // Method : Predicate

        #region ?? Method : Event Handler   ?

        #endregion // Method : Event Handler

        #region ?? Method : Function        ?

        #endregion // Method : Function

        #endregion // Method
    }
}
