using System;

namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_03
{
    public static class ChainOfResponsibility_SupportFactory
    {
        public static ChainOfResponsibility_Support Create(
            string name,
            Func<ChainOfResponsibility_Trouble, bool> resolver)
        {
            return new ChainOfResponsibility_DelegateSupport(name, resolver);
        }

        public static ChainOfResponsibility_Support CreateNotSupport(string name)
        {
            return Create(name, _ => false);
        }

        public static ChainOfResponsibility_Support CreateLimitSupport(string name, int limit)
        {
            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit), "Limit must be zero or positive.");
            }

            return Create(name, trouble => trouble.Number < limit);
        }

        public static ChainOfResponsibility_Support CreateSpecialSupport(string name, int specialNumber)
        {
            if (specialNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(specialNumber), "Special number must be zero or positive.");
            }

            return Create(name, trouble => trouble.Number == specialNumber);
        }

        public static ChainOfResponsibility_Support CreateOddSupport(string name)
        {
            return Create(name, trouble => trouble.Number % 2 == 1);
        }
    }
}
