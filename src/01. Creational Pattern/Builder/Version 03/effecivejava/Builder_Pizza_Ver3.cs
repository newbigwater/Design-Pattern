using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _01.Creational_Pattern.Builder.Version_03
{
    public abstract class Builder_Pizza_Ver3
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
        public IReadOnlyList<Builder_BuildStep_Ver3> BuildHistory { get; }

        protected Builder_Pizza_Ver3(Builder builder)
        {
            var toppingSnapshot = builder.GetToppingsSnapshot().OrderBy(x => x).ToList();
            var historySnapshot = builder.GetStepsSnapshot().ToList();

            Toppings = new ReadOnlyCollection<Topping>(toppingSnapshot);
            BuildHistory = new ReadOnlyCollection<Builder_BuildStep_Ver3>(historySnapshot);
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", Toppings.Select(x => x.ToString())) + "]";
        }

        public abstract class Builder
        {
            private readonly HashSet<Topping> _toppings = new HashSet<Topping>();
            private readonly List<Builder_BuildStep_Ver3> _steps = new List<Builder_BuildStep_Ver3>();

            internal IReadOnlyCollection<Topping> GetToppingsSnapshot()
            {
                return _toppings.ToArray();
            }

            internal IReadOnlyList<Builder_BuildStep_Ver3> GetStepsSnapshot()
            {
                return _steps.ToArray();
            }

            public Builder AddTopping(Topping topping)
            {
                if (!Enum.IsDefined(typeof(Topping), topping))
                {
                    throw new ArgumentOutOfRangeException(nameof(topping));
                }

                _toppings.Add(topping);
                _steps.Add(Builder_BuildStep_Ver3.AddTopping);
                return Self();
            }

            public virtual Builder SauceInside()
            {
                _steps.Add(Builder_BuildStep_Ver3.SauceInside);
                return Self();
            }

            protected void ValidateAndMarkBuild()
            {
                if (_toppings.Count == 0)
                {
                    throw new InvalidOperationException("At least one topping is required.");
                }

                _steps.Add(Builder_BuildStep_Ver3.Build);
            }

            public abstract Builder_Pizza_Ver3 Build();

            protected abstract Builder Self();
        }
    }
}
