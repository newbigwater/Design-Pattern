namespace _01.Creational_Pattern.Builder.Version_03
{
    public class Builder_Calzone_Ver3 : Builder_Pizza_Ver3
    {
        public bool IsSauceInside { get; }

        private Builder_Calzone_Ver3(Builder builder) : base(builder)
        {
            IsSauceInside = builder.IsSauceInside;
        }

        public override string ToString()
        {
            return base.ToString() + " sauceInside: " + IsSauceInside;
        }

        public new class Builder : Builder_Pizza_Ver3.Builder
        {
            public bool IsSauceInside { get; private set; }

            public override Builder_Pizza_Ver3.Builder SauceInside()
            {
                IsSauceInside = true;
                return base.SauceInside();
            }

            public override Builder_Pizza_Ver3 Build()
            {
                ValidateAndMarkBuild();
                return new Builder_Calzone_Ver3(this);
            }

            protected override Builder_Pizza_Ver3.Builder Self()
            {
                return this;
            }
        }
    }
}
