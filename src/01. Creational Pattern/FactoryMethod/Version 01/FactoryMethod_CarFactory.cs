using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Creational_Pattern.FactoryMethod.Version_01
{
    public abstract class FactoryMethod_CarFactory
    {
        #region ▶  Event Handle             ◀

        #endregion // Event Handle

        #region ▶  Fields                   ◀

        private Dictionary<string, FactoryMethod_Car> _carMap = new Dictionary<string, FactoryMethod_Car>();

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

        public abstract FactoryMethod_Car CreateCar(string carType);

        public string ReservationCar(string carType, string reservationName)
        {
            if (!_carMap.TryGetValue(reservationName, out var newCar))
            {
                newCar = CreateCar(carType);
                _carMap.Add(reservationName, newCar);

                return $"'{reservationName}'님의 '{newCar.CarType}' 차량이 예약되었습니다.";
            }
            else
                return $"이미 '{reservationName}'님의 차량은 '{newCar.CarType}'으로 예약되었습니다.";
        }

        public FactoryMethod_Car ReturnCar(string name)
        {
            if (_carMap.TryGetValue(name, out var car))
                return car;
            else
                throw new ArgumentException($"{name}의 차는 보관 중인 차량이 아닙니다.");
        }

        public virtual string Numbering()
        {
            string val = "Numbering";
            Console.WriteLine(val);

            return val;
        }

        public virtual string WashCar()
        {
            string val = "Washing";
            Console.WriteLine(val);

            return val;
        }

        public string SellCar(string carType)
        {
            StringBuilder sb = new StringBuilder();
            {
                sb.AppendLine(Numbering());
                FactoryMethod_Car newCar = CreateCar(carType);
                sb.AppendLine($"Create Car Type : {newCar.CarType}");
                sb.AppendLine(WashCar());
            }
            return sb.ToString();
        }

        #endregion // Method : Function

        #endregion // Method
    }
}