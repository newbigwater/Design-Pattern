using System;

namespace _01.Creational_Pattern.Builder.Version_02
{
    public class Builder_NyPizza_Ver2 : Builder_Pizza_Ver2
    {
        public enum Size
        {
            SMALL,
            MEDIUM,
            LARGE
        }

        public Size PizzaSize { get; }

        private Builder_NyPizza_Ver2(Builder builder) : base(builder)
        {
            PizzaSize = builder.PizzaSize;
        }

        public new class Builder : Builder_Pizza_Ver2.Builder
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

            public override Builder_Pizza_Ver2 Build()
            {
                ValidateBeforeBuild();
                return new Builder_NyPizza_Ver2(this);
            }

            protected override Builder_Pizza_Ver2.Builder Self()
            {
                return this;
            }
        }
    }
}
