using System;

namespace _02.Structural_Pattern.Adapter.Version_02._01._Adaptee
{
    public class Adapter_Banner
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private string value;

        #endregion // Fields

        #region ▶  Properties               ◀

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        public Adapter_Banner(string value)
        {
            this.value = value;
        }

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      ◀

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ▶  Method                   ◀

        #region ▶  Method : Predicate       ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function	    ◀
        public string ShowWithParen()
        {
            Console.WriteLine("(" + value + ")");
            return "(" + value + ")";
        }
        public string ShowWithAster()
        {
            Console.WriteLine("*" + value + "*");
            return "*" + value + "*";
        }

        #endregion // Method : Function

        #endregion // Method
    }
}
