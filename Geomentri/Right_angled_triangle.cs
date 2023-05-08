using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomentri
{
    internal class Right_angled_triangle : Shapes
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



        public Right_angled_triangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Perimeter()
        {
            double Csquared = a * a + b * b;
            double c = Math.Sqrt(Csquared);
            return a + b + c;
        }

        public override double Area()
        {
            return 0.5 * a * b;
        }
    }
}
