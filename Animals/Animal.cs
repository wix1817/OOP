using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public double Satiety { get; protected set; }

        private protected Animal(string name, double satiety)
        {
            Name = name;
            Satiety = satiety;
        }

        public virtual void Feed(FoodType foodType, int count) { }

    }
}
