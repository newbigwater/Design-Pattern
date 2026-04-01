namespace _03.Behavioral_Pattern.Strategy
{
    public class Strategy_RoundRobin : Strategy_Scheduler
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        #endregion // Fields

        #region ▶  Properties               ◀

        public string Name => "Round Robin";

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
            return "상담 전화를 순서대로 대기열에서 가져옵니다.";
        }

        public string SendCallToAgent()
        {
            return "다음 순서 상담원에게 배분합니다.";
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
