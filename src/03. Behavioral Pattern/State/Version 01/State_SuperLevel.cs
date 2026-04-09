using System;

namespace _03.Behavioral_Pattern.State.Version_01
{
    public class State_SuperLevel : State_PlayerLevel
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
        public override string Run()
        {
            string var = "순간 이동합니다.";
            Console.WriteLine(var);

            return var;
        }

        public override string Jump()
        {
            string var = "높이 점프 합니다.";
            Console.WriteLine(var);

            return var;
        }

        public override string Turn()
        {
            string var = "한 바퀴 돕니다.";
            Console.WriteLine(var);

            return var;
        }

        public override string ShowLevelMessage()
        {
            string var = "***** 상급자 레벨 입니다. *****";
            Console.WriteLine(var);

            return var;
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