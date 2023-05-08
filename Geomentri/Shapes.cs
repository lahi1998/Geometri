using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geomentri
{
    internal abstract class Shapes
    {
        protected double a;
        protected double b;


        public virtual double Perimeter()
        {
            return 0;
        }

        public virtual double Area()
        {
            return 0;
        }
    }
}
