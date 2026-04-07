using _03.Behavioral_Pattern.Strategy.Version_01._01._Strategy;

namespace _03.Behavioral_Pattern.Strategy.Version_01._02._Concrete
{
    public class Strategy_AgentGetCall : Strategy_Scheduler
    {
        #region ?? Event Handle             ?

        #endregion // Event Handle

        #region ?? Fields                   ?

        #endregion // Fields

        #region ?? Properties               ?

        public string Name => "Agent Get Call";

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
            return "?곷떞?먯씠 ?ㅼ쓬 ?꾪솕 ?붿껌";
        }

        public string SendCallToAgent()
        {
            return "?곷떞?먯씠 ?꾪솕 ?곷떞??媛?멸컮?듬땲??";
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
