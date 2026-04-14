using System.Collections.Generic;
using System.Linq;

namespace _01.Creational_Pattern.Builder.Version_01
{
    public abstract class Builder_Pizza_Ver1
    {
        public enum Topping
        {
            HAM,
            MUSHROOM,
            ONION,
            PEPPER,
            SAUSAGE
        }

        private readonly HashSet<Topping> _toppings;

        public IEnumerable<Topping> Toppings => _toppings;

        protected Builder_Pizza_Ver1(Builder builder)
        {
            _toppings = new HashSet<Topping>(builder.GetToppingsSnapshot());
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", _toppings.Select(x => x.ToString())) + "]";
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
                _toppings.Add(topping);
                return Self();
            }

            public virtual Builder SauceInside()
            {
                return Self();
            }

            public abstract Builder_Pizza_Ver1 Build();

            protected abstract Builder Self();
        }
    }
}
