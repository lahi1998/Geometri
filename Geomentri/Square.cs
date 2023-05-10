using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Geomentri
{
    internal class Square : Shapes
    {        
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Square(double a) 
        {
            A = a;
        }

        public override double Perimeter()
        {
           return 4 * a;
        }

        public override double Area()
        {
            return a * a;
        }
    }
    
}
