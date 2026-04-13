using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethodVer1 = _01.Creational_Pattern.FactoryMethod.Version_01;
using FactoryMethodVer2 = _01.Creational_Pattern.FactoryMethod.Version_02;

namespace unitTest._01._Creational_Pattern
{
    partial class _01_Creational_Pattern
    {
        [TestMethod("[FactoryMethod Ver1 Creates Sonata]")]
        public void FactoryMethod_Ver1_Creates_Sonata()
        {
            var factory = new FactoryMethodVer1.FactoryMethod_HDI_CarFactory();
            var car = factory.CreateCar(nameof(FactoryMethodVer1.FactoryMethod_Sonata));

            Assert.AreEqual(nameof(FactoryMethodVer1.FactoryMethod_Sonata), car.CarType);
        }

        [TestMethod("[FactoryMethod Ver1 Santafe Creation Fails By Baseline Bug]")]
        public void FactoryMethod_Ver1_Santafe_Creation_Fails_By_Baseline_Bug()
        {
            var factory = new FactoryMethodVer1.FactoryMethod_HDI_CarFactory();

            Assert.ThrowsException<ArgumentException>(
                () => factory.CreateCar(nameof(FactoryMethodVer1.FactoryMethod_Santafe)));
        }

        [TestMethod("[FactoryMethod Ver2 Creates Santafe]")]
        public void FactoryMethod_Ver2_Creates_Santafe()
        {
            var factory = new FactoryMethodVer2.FactoryMethod_HDI_CarFactory();
            var car = factory.CreateCar(nameof(FactoryMethodVer2.FactoryMethod_Santafe));

            Assert.AreEqual(nameof(FactoryMethodVer2.FactoryMethod_Santafe), car.CarType);
        }

        [TestMethod("[FactoryMethod Ver2 Supports Case And Trim Input]")]
        public void FactoryMethod_Ver2_Supports_Case_And_Trim_Input()
        {
            var factory = new FactoryMethodVer2.FactoryMethod_HDI_CarFactory();
            var car = factory.CreateCar("  factorymethod_sonata ");

            Assert.AreEqual(nameof(FactoryMethodVer2.FactoryMethod_Sonata), car.CarType);
        }

        [TestMethod("[FactoryMethod Ver2 Rejects Empty Reservation Name]")]
        public void FactoryMethod_Ver2_Rejects_Empty_Reservation_Name()
        {
            var factory = new FactoryMethodVer2.FactoryMethod_HDI_CarFactory();

            Assert.ThrowsException<ArgumentException>(
                () => factory.ReservationCar(nameof(FactoryMethodVer2.FactoryMethod_Sonata), " "));
        }

        [TestMethod("[FactoryMethod Ver2 Rejects Empty Car Type On Sell]")]
        public void FactoryMethod_Ver2_Rejects_Empty_Car_Type_On_Sell()
        {
            var factory = new FactoryMethodVer2.FactoryMethod_HDI_CarFactory();

            Assert.ThrowsException<ArgumentException>(() => factory.SellCar(string.Empty));
        }

        [TestMethod("[FactoryMethod Ver2 Scenario Reuses Reserved Car By Owner]")]
        public void FactoryMethod_Ver2_Scenario_Reuses_Reserved_Car_By_Owner()
        {
            var factory = new FactoryMethodVer2.FactoryMethod_HDI_CarFactory();

            var created = factory.CreateCar("factorymethod_sonata");
            var firstReservationMessage = factory.ReservationCar(nameof(FactoryMethodVer2.FactoryMethod_Sonata), "Tomas");
            var secondReservationMessage = factory.ReservationCar(nameof(FactoryMethodVer2.FactoryMethod_Santafe), "Tomas");
            var myCar = factory.ReturnCar("Tomas");
            var hisCar = factory.ReturnCar("Tomas");

            Assert.AreEqual(nameof(FactoryMethodVer2.FactoryMethod_Sonata), created.CarType);
            StringAssert.Contains(firstReservationMessage, "예약되었습니다");
            StringAssert.Contains(secondReservationMessage, "이미 'Tomas'님의 차량은 'FactoryMethod_Sonata'으로 예약되었습니다.");
            Assert.AreSame(myCar, hisCar);
            Assert.AreEqual(nameof(FactoryMethodVer2.FactoryMethod_Sonata), myCar.CarType);
        }
    }
}
