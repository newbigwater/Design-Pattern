namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_01
{
    public class ChainOfResponsibility_Trouble
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀


        private readonly int _number;

        #endregion // Fields

        #region ▶  Properties               ◀

        public int Number
        {
            get { return _number; }
        }

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        public ChainOfResponsibility_Trouble(int number)
        {
            _number = number;
        }

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      

        public override string ToString()
        {
            return $"[Trouble {_number}]";
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