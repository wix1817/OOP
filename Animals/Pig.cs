using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public sealed class Pig : Animal
    {
        public int Weight { get; private set; }

        public Pig(string name, double satiety, int weight) : base(name, satiety)
        {
            Name = name;
            Satiety = satiety;
            Weight = weight;
        }

        public override void Feed(FoodType foodType, int count)
        {
            if (foodType != FoodType.PigFood)
            {
                Console.WriteLine("Phrrr, I dont eat this!");

                return;
            }

            Satiety += count;
            Weight += 1;
            Console.WriteLine("Phrrr, Om-nom-nom");
        }
    }
}
