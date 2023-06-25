using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 6, 3, 5, 1, 8, 0, 9, 2, 7, 4, 53 };
            Console.Write("List:\t"); PrintList(intList);
            intList.Sort();
            Console.Write("Sorted:\t"); PrintList(intList);
            Console.Write("Even numbers:\t"); PrintList(intList.FindAll(x => x % 2 == 0));
            Console.Write("Numbers > 42:\t"); PrintList(intList.FindAll(x => x > 42));
            Console.WriteLine("Sum:\t" + intList.Sum());

            //----------------------------------------------------------------------------------------------

            List<string> strList = new List<string>() { "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Lorem Ipsum has been the industry's standard dummy text ever since the 1s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.", "sdfsdfsdsdfsdfsdfsdf", "blabla" };
            PrintList(strList);
            Console.Write("Without spaces:\t"); PrintList(strList.FindAll(x => !x.Contains(" ")));
            Console.Write("Start from Upper:\t"); PrintList(strList.FindAll(x => Char.IsUpper(x.First())));
            Console.Write("Input string to find: ");
            var str = Console.ReadLine();
            PrintList(strList.FindAll(x => x == str));
            Console.Write("Is numbers here? \t"); Console.Write(strList.Any(x => x.Any(y => Char.IsDigit(y))));
        }

        public static void PrintList<T>(List<T> list)
        {
            foreach (var x in list)
            {
                Console.Write(x + "\t");
            }
            Console.WriteLine();
        }
    }
}