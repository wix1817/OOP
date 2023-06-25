using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class Circl : Figure
    {
        private double Radius;

        public Circl(double radius)
        {
            Radius = radius;
        }
        public Double GetSquare()
        {
            return Math.PI * Radius;
        }
    }
}
