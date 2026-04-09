using System.Text;

namespace _03.Behavioral_Pattern.State.Version_01
{
    public class State_Player
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private State_PlayerLevel _level;

        #endregion // Fields

        #region ▶  Properties               ◀
        public State_PlayerLevel Level => _level;

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        public State_Player()
        {
            _level = new State_BeginnerLevel();
            _level.ShowLevelMessage();
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
        
        public void UpgradeLevel(State_PlayerLevel level)
        {
            _level = level;
            _level.ShowLevelMessage();
        }

        public string Play(int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_level.Run());

            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(_level.Jump());
            }

            sb.AppendLine(_level.Turn());

            return sb.ToString();
        }

        #endregion // Method : Function

        #endregion // Method
    }
}