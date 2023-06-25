namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Barsik", 0);
            cat.Feed(FoodType.CatFood, 5);
            Console.WriteLine($"Satiety = {cat.Satiety}");

            var pig = new Pig("Putin", 0, 160);
            pig.Feed(FoodType.PigFood, 5);
            Console.WriteLine($"Satiety = {pig.Satiety}");
            Console.WriteLine($"Pig weight = {pig.Weight}");
        }
    }
}