namespace _01.Creational_Pattern.Builder.Version_01
{
    public class Builder_NyPizza_Ver1 : Builder_Pizza_Ver1
    {
        public enum Size
        {
            SMALL,
            MEDIUM,
            LARGE
        }

        public Size PizzaSize { get; }

        private Builder_NyPizza_Ver1(Builder builder) : base(builder)
        {
            PizzaSize = builder.PizzaSize;
        }

        public new class Builder : Builder_Pizza_Ver1.Builder
        {
            public Size PizzaSize { get; }

            public Builder(Size size)
            {
                PizzaSize = size;
            }

            public override Builder_Pizza_Ver1 Build()
            {
                return new Builder_NyPizza_Ver1(this);
            }

            protected override Builder_Pizza_Ver1.Builder Self()
            {
                return this;
            }
        }
    }
}
