using System;

namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_02
{
    public abstract class ChainOfResponsibility_Support
    {
        private readonly string _name;
        private ChainOfResponsibility_Support _next;

        protected ChainOfResponsibility_Support(string name)
        {
            _name = name;
        }

        public ChainOfResponsibility_Support SetNext(ChainOfResponsibility_Support next)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            _next = next;
            return next;
        }

        public ChainOfResponsibility_Result SupportRequest(ChainOfResponsibility_Trouble trouble)
        {
            if (trouble == null)
            {
                throw new ArgumentNullException(nameof(trouble));
            }

            if (Resolve(trouble))
            {
                return ChainOfResponsibility_Result.Resolved(trouble, ToString());
            }

            if (_next != null)
            {
                return _next.SupportRequest(trouble);
            }

            return ChainOfResponsibility_Result.Failed(trouble);
        }

        protected abstract bool Resolve(ChainOfResponsibility_Trouble trouble);

        public override string ToString()
        {
            return "[" + _name + "]";
        }
    }
}
