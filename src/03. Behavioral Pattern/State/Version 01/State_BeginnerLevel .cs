using System;

namespace _03.Behavioral_Pattern.State.Version_01
{
    public class State_BeginnerLevel : State_PlayerLevel
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
            string var = "천천히 달립니다.";
            Console.WriteLine(var);

            return var;
        }

        public override string Jump()
        {
            string var = "Jump - 할 수 없는 레벨입니다.";
            Console.WriteLine(var);

            return var;
        }

        public override string Turn()
        {
            string var = "Turn - 할 수 없는 레벨입니다.";
            Console.WriteLine(var);

            return var;
        }

        public override string ShowLevelMessage()
        {
            string var = "***** 초보자 레벨 입니다. *****";
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