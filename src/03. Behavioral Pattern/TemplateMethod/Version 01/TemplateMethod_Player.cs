namespace _03.Behavioral_Pattern.TemplateMethod.Version_01
{
    public class TemplateMethod_Player
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private TemplateMethod_PlayerLevel _level;

        #endregion // Fields

        #region ▶  Properties               ◀
        public TemplateMethod_PlayerLevel Level => _level;

        #endregion // Properties

        ////////////////////////////////////////

        #region ▶  Constructor              ◀

        public TemplateMethod_Player()
        {
            _level = new TemplateMethod_BeginnerLevel();
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


        public void UpgradeLevel(TemplateMethod_PlayerLevel level)
        {
            _level = level;
            _level.ShowLevelMessage();
        }

        public void Play(int count)
        {
            _level.Go(count);
        }

        #endregion // Method : Function

        #endregion // Method
    }
}