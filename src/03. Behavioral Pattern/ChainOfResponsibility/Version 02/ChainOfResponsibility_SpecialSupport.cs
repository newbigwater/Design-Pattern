namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_02
{
    public class ChainOfResponsibility_SpecialSupport : ChainOfResponsibility_Support
    {
        private readonly int _specialNumber;

        public ChainOfResponsibility_SpecialSupport(string name, int specialNumber) : base(name)
        {
            _specialNumber = specialNumber;
        }

        protected override bool Resolve(ChainOfResponsibility_Trouble trouble)
        {
            return trouble.Number == _specialNumber;
        }
    }
}
