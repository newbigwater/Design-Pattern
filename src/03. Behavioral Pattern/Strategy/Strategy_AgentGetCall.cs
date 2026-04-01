namespace _03.Behavioral_Pattern.Strategy
{
    public class Strategy_AgentGetCall : Strategy_Scheduler
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        #endregion // Fields

        #region ▶  Properties               ◀

        public string Name => "Agent Get Call";

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      ◀

        public string GetNextCall()
        {
            return "상담원이 다음 전화 요청";
        }

        public string SendCallToAgent()
        {
            return "상담원이 전화 상담을 가져갔습니다.";
        }

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ▶  Method                   ◀

        #region ▶  Method : Predicate       ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function        ◀

        #endregion // Method : Function

        #endregion // Method
    }
}
