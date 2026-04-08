using System;
using System.Collections.Generic;

namespace _01.Creational_Pattern.FactoryMethod.Version_02
{
    public class FactoryMethod_HDI_CarFactory : FactoryMethod_CarFactory
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private readonly Dictionary<string, Func<FactoryMethod_Car>> _carFactoryMap =
            new Dictionary<string, Func<FactoryMethod_Car>>(StringComparer.OrdinalIgnoreCase)
            {
                { typeof(FactoryMethod_Sonata).Name, () => new FactoryMethod_Sonata() },
                { typeof(FactoryMethod_Santafe).Name, () => new FactoryMethod_Santafe() }
            };

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
            if (string.IsNullOrWhiteSpace(carType))
                throw new ArgumentException("차량 타입은 비워둘 수 없습니다.", nameof(carType));

            if (_carFactoryMap.TryGetValue(carType.Trim(), out var creator))
                return creator();

            throw new ArgumentException($"{carType}의 차량은 생산할 수 없는 차량입니다.", nameof(carType));
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
