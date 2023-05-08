using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomentri
{
    internal class Rectangle : Shapes
    {
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Perimeter()
        {
            return 2 * (a + b);
        }

        public override double Area()
        {
            return a * b;
        }
    }
}
