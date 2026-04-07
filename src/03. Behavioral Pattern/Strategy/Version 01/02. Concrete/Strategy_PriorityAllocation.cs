using _03.Behavioral_Pattern.Strategy.Version_01._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_01._02._Concrete
{
    public class Strategy_PriorityAllocation : Strategy_Scheduler
    {
        #region ?? Event Handle             ?

        #endregion // Event Handle

        #region ?? Fields                   ?

        #endregion // Fields

        #region ?? Properties               ?

        public string Name => "Priority Allocation";

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
            return "怨좉컼 ?깃툒???믪? 怨좉컼???꾪솕瑜?癒쇱? 媛?몄샃?덈떎.";
        }

        public string SendCallToAgent()
        {
            return "?낅Т skill 媛믪씠 ?믪? ?곷떞?먯뿉寃??곗꽑?곸쑝濡?諛곕텇?⑸땲??";
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
