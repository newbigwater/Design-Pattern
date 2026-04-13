namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_03
{
    public sealed class ChainOfResponsibility_Result
    {
        private readonly bool _isResolved;
        private readonly string _resolver;
        private readonly ChainOfResponsibility_Trouble _trouble;

        public bool IsResolved
        {
            get { return _isResolved; }
        }

        public string Resolver
        {
            get { return _resolver; }
        }

        public ChainOfResponsibility_Trouble Trouble
        {
            get { return _trouble; }
        }

        public string Message
        {
            get
            {
                if (_isResolved)
                {
                    return $"{_trouble} is resolved by {_resolver}.";
                }

                return $"{_trouble} cannot be resolved.";
            }
        }

        private ChainOfResponsibility_Result(ChainOfResponsibility_Trouble trouble, bool isResolved, string resolver)
        {
            _trouble = trouble;
            _isResolved = isResolved;
            _resolver = resolver;
        }

        public static ChainOfResponsibility_Result Resolved(ChainOfResponsibility_Trouble trouble, string resolver)
        {
            return new ChainOfResponsibility_Result(trouble, true, resolver);
        }

        public static ChainOfResponsibility_Result Failed(ChainOfResponsibility_Trouble trouble)
        {
            return new ChainOfResponsibility_Result(trouble, false, null);
        }
    }
}
