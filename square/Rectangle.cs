using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class Rectangle : Figure
    {
        private double FirstSide;
        private double SecondSide;
        public Rectangle(double firstSide, double secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        public double GetSquare()
        {
            return FirstSide * SecondSide;
        }
    }
}
