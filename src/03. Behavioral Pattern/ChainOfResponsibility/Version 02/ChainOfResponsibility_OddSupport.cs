namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_02
{
    public class ChainOfResponsibility_OddSupport : ChainOfResponsibility_Support
    {
        public ChainOfResponsibility_OddSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(ChainOfResponsibility_Trouble trouble)
        {
            return trouble.Number % 2 == 1;
        }
    }
}
