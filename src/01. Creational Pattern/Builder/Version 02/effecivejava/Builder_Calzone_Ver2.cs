namespace _01.Creational_Pattern.Builder.Version_02
{
    public class Builder_Calzone_Ver2 : Builder_Pizza_Ver2
    {
        public bool IsSauceInside { get; }

        private Builder_Calzone_Ver2(Builder builder) : base(builder)
        {
            IsSauceInside = builder.IsSauceInside;
        }

        public override string ToString()
        {
            return base.ToString() + " sauceInside: " + IsSauceInside;
        }

        public new class Builder : Builder_Pizza_Ver2.Builder
        {
            public bool IsSauceInside { get; private set; }

            public override Builder_Pizza_Ver2.Builder SauceInside()
            {
                IsSauceInside = true;
                return this;
            }

            public override Builder_Pizza_Ver2 Build()
            {
                ValidateBeforeBuild();
                return new Builder_Calzone_Ver2(this);
            }

            protected override Builder_Pizza_Ver2.Builder Self()
            {
                return this;
            }
        }
    }
}
