namespace _01.Creational_Pattern.Builder.Version_01
{
    public class Builder_Calzone_Ver1 : Builder_Pizza_Ver1
    {
        public bool IsSauceInside { get; }

        private Builder_Calzone_Ver1(Builder builder) : base(builder)
        {
            IsSauceInside = builder.IsSauceInside;
        }

        public override string ToString()
        {
            return base.ToString() + " sauceInside: " + IsSauceInside;
        }

        public new class Builder : Builder_Pizza_Ver1.Builder
        {
            public bool IsSauceInside { get; private set; }

            public override Builder_Pizza_Ver1.Builder SauceInside()
            {
                IsSauceInside = true;
                return this;
            }

            public override Builder_Pizza_Ver1 Build()
            {
                return new Builder_Calzone_Ver1(this);
            }

            protected override Builder_Pizza_Ver1.Builder Self()
            {
                return this;
            }
        }
    }
}
