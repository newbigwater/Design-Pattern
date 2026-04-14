using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderVer1 = _01.Creational_Pattern.Builder.Version_01;
using BuilderVer2 = _01.Creational_Pattern.Builder.Version_02;
using BuilderVer3 = _01.Creational_Pattern.Builder.Version_03;

namespace unitTest._01._Creational_Pattern
{
    partial class _01_Creational_Pattern
    {
        [TestMethod("[Builder Ver1 Converts Java Main Flow To CSharp NyPizza]")]
        public void Builder_Ver1_Converts_Java_Main_Flow_To_CSharp_NyPizza()
        {
            var nyPizza = new BuilderVer1.Builder_NyPizza_Ver1.Builder(BuilderVer1.Builder_NyPizza_Ver1.Size.SMALL)
                .AddTopping(BuilderVer1.Builder_Pizza_Ver1.Topping.SAUSAGE)
                .AddTopping(BuilderVer1.Builder_Pizza_Ver1.Topping.ONION)
                .Build();

            var typedPizza = nyPizza as BuilderVer1.Builder_NyPizza_Ver1;

            Assert.IsNotNull(typedPizza);
            CollectionAssert.AreEquivalent(
                new[]
                {
                    BuilderVer1.Builder_Pizza_Ver1.Topping.SAUSAGE,
                    BuilderVer1.Builder_Pizza_Ver1.Topping.ONION
                },
                typedPizza.Toppings.ToArray());
            Assert.AreEqual(BuilderVer1.Builder_NyPizza_Ver1.Size.SMALL, typedPizza.PizzaSize);
        }

        [TestMethod("[Builder Ver1 Scenario Builds Calzone With SauceInside]")]
        public void Builder_Ver1_Scenario_Builds_Calzone_With_SauceInside()
        {
            var calzone = new BuilderVer1.Builder_Calzone_Ver1.Builder()
                .AddTopping(BuilderVer1.Builder_Pizza_Ver1.Topping.HAM)
                .AddTopping(BuilderVer1.Builder_Pizza_Ver1.Topping.PEPPER)
                .SauceInside()
                .Build();

            var typedPizza = calzone as BuilderVer1.Builder_Calzone_Ver1;

            Assert.IsNotNull(typedPizza);
            Assert.IsTrue(typedPizza.IsSauceInside);
            CollectionAssert.AreEquivalent(
                new[]
                {
                    BuilderVer1.Builder_Pizza_Ver1.Topping.HAM,
                    BuilderVer1.Builder_Pizza_Ver1.Topping.PEPPER
                },
                typedPizza.Toppings.ToArray());
        }

        [TestMethod("[Builder Ver2 Throws When Building Without Topping]")]
        public void Builder_Ver2_Throws_When_Building_Without_Topping()
        {
            Assert.ThrowsException<InvalidOperationException>(
                () => new BuilderVer2.Builder_NyPizza_Ver2.Builder(BuilderVer2.Builder_NyPizza_Ver2.Size.SMALL).Build());
        }

        [TestMethod("[Builder Ver2 Throws On Invalid Size Enum]")]
        public void Builder_Ver2_Throws_On_Invalid_Size_Enum()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new BuilderVer2.Builder_NyPizza_Ver2.Builder((BuilderVer2.Builder_NyPizza_Ver2.Size)999));
        }

        [TestMethod("[Builder Ver2 Scenario Keeps Deterministic Topping Order]")]
        public void Builder_Ver2_Scenario_Keeps_Deterministic_Topping_Order()
        {
            var nyPizza = new BuilderVer2.Builder_NyPizza_Ver2.Builder(BuilderVer2.Builder_NyPizza_Ver2.Size.SMALL)
                .AddTopping(BuilderVer2.Builder_Pizza_Ver2.Topping.SAUSAGE)
                .AddTopping(BuilderVer2.Builder_Pizza_Ver2.Topping.ONION)
                .Build();

            var typedPizza = nyPizza as BuilderVer2.Builder_NyPizza_Ver2;

            Assert.IsNotNull(typedPizza);
            CollectionAssert.AreEqual(
                new[]
                {
                    BuilderVer2.Builder_Pizza_Ver2.Topping.ONION,
                    BuilderVer2.Builder_Pizza_Ver2.Topping.SAUSAGE
                },
                typedPizza.Toppings.ToArray());
        }

        [TestMethod("[Builder Ver3 Director Scenario Preserves Build Step Order]")]
        public void Builder_Ver3_Director_Scenario_Preserves_Build_Step_Order()
        {
            var director = new BuilderVer3.Builder_PizzaDirector_Ver3();

            var nyPizza = director.CreateMainScenarioNyPizza();
            var calzone = director.CreateMainScenarioCalzone() as BuilderVer3.Builder_Calzone_Ver3;

            Assert.IsNotNull(calzone);
            CollectionAssert.AreEqual(
                new[]
                {
                    BuilderVer3.Builder_BuildStep_Ver3.AddTopping,
                    BuilderVer3.Builder_BuildStep_Ver3.AddTopping,
                    BuilderVer3.Builder_BuildStep_Ver3.Build
                },
                nyPizza.BuildHistory.ToArray());
            CollectionAssert.AreEqual(
                new[]
                {
                    BuilderVer3.Builder_BuildStep_Ver3.AddTopping,
                    BuilderVer3.Builder_BuildStep_Ver3.AddTopping,
                    BuilderVer3.Builder_BuildStep_Ver3.SauceInside,
                    BuilderVer3.Builder_BuildStep_Ver3.Build
                },
                calzone.BuildHistory.ToArray());
            Assert.IsTrue(calzone.IsSauceInside);
        }

        [TestMethod("[Builder Ver3 Keeps Product Snapshot After Builder Reuse]")]
        public void Builder_Ver3_Keeps_Product_Snapshot_After_Builder_Reuse()
        {
            var builder = new BuilderVer3.Builder_Calzone_Ver3.Builder();
            var first = builder
                .AddTopping(BuilderVer3.Builder_Pizza_Ver3.Topping.HAM)
                .SauceInside()
                .Build() as BuilderVer3.Builder_Calzone_Ver3;

            var second = builder
                .AddTopping(BuilderVer3.Builder_Pizza_Ver3.Topping.PEPPER)
                .Build() as BuilderVer3.Builder_Calzone_Ver3;

            Assert.IsNotNull(first);
            Assert.IsNotNull(second);
            CollectionAssert.AreEqual(
                new[] { BuilderVer3.Builder_Pizza_Ver3.Topping.HAM },
                first.Toppings.ToArray());
            CollectionAssert.AreEqual(
                new[]
                {
                    BuilderVer3.Builder_Pizza_Ver3.Topping.HAM,
                    BuilderVer3.Builder_Pizza_Ver3.Topping.PEPPER
                },
                second.Toppings.ToArray());
        }
    }
}
