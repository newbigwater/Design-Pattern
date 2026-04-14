using System;

namespace _01.Creational_Pattern.Builder.Version_03
{
    public class Builder_NyPizza_Ver3 : Builder_Pizza_Ver3
    {
        public enum Size
        {
            SMALL,
            MEDIUM,
            LARGE
        }

        public Size PizzaSize { get; }

        private Builder_NyPizza_Ver3(Builder builder) : base(builder)
        {
            PizzaSize = builder.PizzaSize;
        }

        public new class Builder : Builder_Pizza_Ver3.Builder
        {
            public Size PizzaSize { get; }

            public Builder(Size size)
            {
                if (!Enum.IsDefined(typeof(Size), size))
                {
                    throw new ArgumentOutOfRangeException(nameof(size));
                }

                PizzaSize = size;
            }

            public override Builder_Pizza_Ver3 Build()
            {
                ValidateAndMarkBuild();
                return new Builder_NyPizza_Ver3(this);
            }

            protected override Builder_Pizza_Ver3.Builder Self()
            {
                return this;
            }
        }
    }
}
