namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_02
{
    public class ChainOfResponsibility_LimitSupport : ChainOfResponsibility_Support
    {
        private readonly int _limit;

        public ChainOfResponsibility_LimitSupport(string name, int limit) : base(name)
        {
            _limit = limit;
        }

        protected override bool Resolve(ChainOfResponsibility_Trouble trouble)
        {
            return trouble.Number < _limit;
        }
    }
}
