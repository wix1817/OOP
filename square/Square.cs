using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class Square : Rectangle
    {
        private double Side;
        public Square(double side) : base(side, side)
        {
            Side = side;
        }

        public double GetSquare()
        {
            return Math.Pow(Side, 2);
        }
    }
}
