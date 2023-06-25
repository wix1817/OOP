using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public sealed class Cat : Animal
    {
        public Cat(string name, double satiety) : base(name, satiety)
        {
            Name = name;
            Satiety = satiety;
        }

        public override void Feed(FoodType foodType, int count)
        {
            if (foodType != FoodType.CatFood)
            {
                Console.WriteLine("Meow, I don't eat this!");

                return;
            }

            Satiety += count;
            Console.WriteLine("Meow, Om-nom-nom");
        }
    }
}
