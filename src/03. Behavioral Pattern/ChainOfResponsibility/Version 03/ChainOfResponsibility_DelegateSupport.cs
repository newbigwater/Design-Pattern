using System;

namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_03
{
    public class ChainOfResponsibility_DelegateSupport : ChainOfResponsibility_Support
    {
        private readonly Func<ChainOfResponsibility_Trouble, bool> _resolver;

        public ChainOfResponsibility_DelegateSupport(string name, Func<ChainOfResponsibility_Trouble, bool> resolver)
            : base(name)
        {
            _resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
        }

        protected override bool Resolve(ChainOfResponsibility_Trouble trouble)
        {
            return _resolver(trouble);
        }
    }
}
