using _02.Structural_Pattern.Adapter.Version_01._01._Adaptee;
using _02.Structural_Pattern.Adapter.Version_01._02._Target;

namespace _02.Structural_Pattern.Adapter.Version_01._03._Adapter
{
    public class Adapter_PrintBanner_Ver1 : Adapter_Print_Ver1
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private Adapter_Banner _banner;

        #endregion // Fields

        #region ▶  Properties               ◀

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        public Adapter_PrintBanner_Ver1(Adapter_Banner banner)
        {
            _banner = banner;
        }

        #endregion // Constructor

        ////////////////////////////////////////

        #region ▶  Override                 ◀

        #region ▶  Override : Predicate     ◀

        #endregion // Override : Predicate

        #region ▶  Override : Event Handler ◀

        #endregion // Override : Event Handler

        #region ▶  Override : Function      ◀

        public override string PrintWeak()
        {
            return _banner.ShowWithParen();
        }

        public override string PrintStrong()
        {
            return _banner.ShowWithAster();
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
