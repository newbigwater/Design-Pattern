using System.Text;

namespace _03.Behavioral_Pattern.TemplateMethod.Version_01
{
    public abstract class TemplateMethod_PlayerLevel
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀



        #endregion // Fields

        #region ▶  Properties               ◀

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

        #endregion // Override : Function

        #endregion // Override

        ////////////////////////////////////////

        #region ▶  Method                   ◀

        #region ▶  Method : Predicate       ◀

        #endregion // Method : Predicate

        #region ▶  Method : Event Handler   ◀

        #endregion // Method : Event Handler

        #region ▶  Method : Function	    ◀
        public abstract string Run();
        public abstract string Jump();
        public abstract string Turn();
        public abstract string ShowLevelMessage();

        public string Go(int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Run());

            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(Jump());
            }

            sb.AppendLine(Turn());

            return sb.ToString();
        }

        #endregion // Method : Function

        #endregion // Method
    }
}