namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_01
{
    public class ChainOfResponsibility_NotSupport : ChainOfResponsibility_Support
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private readonly int _limit;

        #endregion // Fields

        #region ▶  Properties               ◀

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        public ChainOfResponsibility_NotSupport(string name) : base(name)
        {
        }

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      ◀

        protected override bool Resolve(ChainOfResponsibility_Trouble trouble)
        {
            return false;
        }

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ▶  Method                   ◀

        #region ▶  Method : Predicate       ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function	    ◀

        #endregion // Method : Function

        #endregion // Method
    }
}