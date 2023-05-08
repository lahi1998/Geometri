using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomentri
{
    internal class Trapeze : Shapes
    {
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double c;
        private double d;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double D
        {
            get { return d; }
            set { d = value; }
        }

        public Trapeze(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public double Height()
        {
            // h = sqrt(c^2 - ((b - a)^2 + d^2 - c^2) / (2 * (b - a)))

            double Form = c * c - ((b - a) * (b - a) + d * d - c * c) / (2 * (b - a));

            return Math.Sqrt(Form);
        }

        public override double Perimeter()
        {
            return a + b + c + d;
        }

        public override double Area()
        {
            double height = Height();

            return ((a + b) / 2) * height;
        }
    }
}
