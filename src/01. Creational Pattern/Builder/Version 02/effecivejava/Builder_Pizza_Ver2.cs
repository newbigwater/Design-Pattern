using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _01.Creational_Pattern.Builder.Version_02
{
    public abstract class Builder_Pizza_Ver2
    {
        public enum Topping
        {
            HAM,
            MUSHROOM,
            ONION,
            PEPPER,
            SAUSAGE
        }

        public IReadOnlyList<Topping> Toppings { get; }

        protected Builder_Pizza_Ver2(Builder builder)
        {
            var snapshot = builder.GetToppingsSnapshot().OrderBy(x => x).ToList();
            Toppings = new ReadOnlyCollection<Topping>(snapshot);
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", Toppings.Select(x => x.ToString())) + "]";
        }

        public abstract class Builder
        {
            private readonly HashSet<Topping> _toppings = new HashSet<Topping>();

            internal IReadOnlyCollection<Topping> GetToppingsSnapshot()
            {
                return _toppings.ToArray();
            }

            public Builder AddTopping(Topping topping)
            {
                if (!Enum.IsDefined(typeof(Topping), topping))
                {
                    throw new ArgumentOutOfRangeException(nameof(topping));
                }

                _toppings.Add(topping);
                return Self();
            }

            public virtual Builder SauceInside()
            {
                return Self();
            }

            protected void ValidateBeforeBuild()
            {
                if (_toppings.Count == 0)
                {
                    throw new InvalidOperationException("At least one topping is required.");
                }
            }

            public abstract Builder_Pizza_Ver2 Build();

            protected abstract Builder Self();
        }
    }
}
