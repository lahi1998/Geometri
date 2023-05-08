using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomentri
{
    internal class Parallelogram : Shapes
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

        private double v;

        public double V
        {
            get { return v; }
            set { v = value; }
        }

        public Parallelogram(double a, double b, double v)
        {
            A = a;
            B = b;
            V = v;
        }

        public override double Perimeter()
        {
            return 2 * a + 2 * b;
        }

        public override double Area()
        {
            
            return a * b * Math.Sin(v);
        }
    }
}
