using System;

namespace _03.Behavioral_Pattern.ChainOfResponsibility.Version_02
{
    public class ChainOfResponsibility_Trouble
    {
        private readonly int _number;

        public int Number
        {
            get { return _number; }
        }

        public ChainOfResponsibility_Trouble(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Trouble number must be zero or positive.");
            }

            _number = number;
        }

        public override string ToString()
        {
            return $"[Trouble {_number}]";
        }
    }
}
