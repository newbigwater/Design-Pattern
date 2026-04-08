using System;

namespace _01.Creational_Pattern.FactoryMethod.Version_01
{
    public class FactoryMethod_HDI_CarFactory : FactoryMethod_CarFactory
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

        public override FactoryMethod_Car CreateCar(string carType)
        {
            if (typeof(FactoryMethod_Sonata).Name == carType)
                return new FactoryMethod_Sonata();
            else if (typeof(FactoryMethod_Sonata).Name == carType)
                return new FactoryMethod_Sonata();
            else
                throw new ArgumentException($"{carType}의 차량은 생산할 수 없는 차량입니다.");
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