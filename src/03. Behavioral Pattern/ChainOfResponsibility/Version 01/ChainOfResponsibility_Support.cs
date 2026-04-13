using System;

namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_01
{
    public abstract class ChainOfResponsibility_Support
    {
		#region ▶  Event Handle             ◀

		#endregion // Event Handle

		#region ▶  Fields                   ◀

		private readonly string _name;
        private ChainOfResponsibility_Support _next;

        #endregion // Fields

        #region ▶  Properties               ◀

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        protected ChainOfResponsibility_Support(string name)
        {
            _name = name;
        }

        public ChainOfResponsibility_Support SetNext(ChainOfResponsibility_Support next)
        {
            _next = next;
            return next;
        }

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      ◀

        public override string ToString()
        {
            return "[" + _name + "]";
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

        public void SupportRequest(ChainOfResponsibility_Trouble trouble)
        {
            if (Resolve(trouble))
            {
                Done(trouble);
            }
            else if (_next != null)
            {
                _next.SupportRequest(trouble);
            }
            else
            {
                Fail(trouble);
            }
        }

        protected abstract bool Resolve(ChainOfResponsibility_Trouble trouble);

        protected string Done(ChainOfResponsibility_Trouble trouble)
        {
            string val = $"{trouble} is resolved by {this}.";
            Console.WriteLine(val);

            return val;
        }

        protected string Fail(ChainOfResponsibility_Trouble trouble)
        {
            string val = $"{trouble} cannot be resolved.";
            Console.WriteLine(val);

            return val;
        }

        #endregion // Method : Function

        #endregion // Method
    }
}