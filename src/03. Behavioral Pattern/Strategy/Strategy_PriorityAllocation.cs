namespace _03.Behavioral_Pattern.Strategy
{
    public class Strategy_PriorityAllocation : Strategy_Scheduler
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        #endregion // Fields

        #region ▶  Properties               ◀

        public string Name => "Priority Allocation";

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
            return "고객 등급이 높은 고객의 전화를 먼저 가져옵니다.";
        }

        public string SendCallToAgent()
        {
            return "업무 skill 값이 높은 상담원에게 우선적으로 배분합니다.";
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
