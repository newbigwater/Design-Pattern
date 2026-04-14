namespace _01.Creational_Pattern.Builder.Version_03
{
    public class Builder_PizzaDirector_Ver3
    {
        public Builder_Pizza_Ver3 CreateMainScenarioNyPizza()
        {
            return new Builder_NyPizza_Ver3.Builder(Builder_NyPizza_Ver3.Size.SMALL)
                .AddTopping(Builder_Pizza_Ver3.Topping.SAUSAGE)
                .AddTopping(Builder_Pizza_Ver3.Topping.ONION)
                .Build();
        }

        public Builder_Pizza_Ver3 CreateMainScenarioCalzone()
        {
            return new Builder_Calzone_Ver3.Builder()
                .AddTopping(Builder_Pizza_Ver3.Topping.HAM)
                .AddTopping(Builder_Pizza_Ver3.Topping.PEPPER)
                .SauceInside()
                .Build();
        }
    }
}
