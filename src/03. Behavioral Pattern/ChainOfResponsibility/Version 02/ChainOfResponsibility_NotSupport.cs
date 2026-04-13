namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_02
{
    public class ChainOfResponsibility_NotSupport : ChainOfResponsibility_Support
    {
        public ChainOfResponsibility_NotSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(ChainOfResponsibility_Trouble trouble)
        {
            return false;
        }
    }
}
