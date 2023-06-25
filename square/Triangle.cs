using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class Triangle : Figure
    {
        private double Base;
        private double Height;

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double GetSquare()
        {
            return 0.5 * Base * Height;
        }
    }
}
