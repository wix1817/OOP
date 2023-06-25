namespace square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5.5, 10.10);
            Console.WriteLine("Rectangle area = {0}", rect.GetSquare());

            Square square = new Square(5);
            Console.WriteLine("Square area = {0}", square.GetSquare());

            Triangle triangle = new Triangle(7, 12);
            Console.WriteLine("Triangle area = {0}", triangle.GetSquare());

            Circl circle = new Circl(12.3);
            Console.WriteLine("Circle area = {0}", circle.GetSquare());
        }
    }

}