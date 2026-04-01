namespace _03.Behavioral_Pattern.Strategy
{
    public class Strategy_LeastJob : Strategy_Scheduler
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        #endregion // Fields

        #region ▶  Properties               ◀

        public string Name => "Least Job";

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
            return "현재 상담업무가 없거나 상담 대기가 가장 적은 상담원에게 할당합니다.";
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
