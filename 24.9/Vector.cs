using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._9
{
    internal class Vector
    {
        public double x; 
        public double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector Somma (Vector vettore)
        {
            return new Vector (x+vettore.x,y+vettore.y);
        }


    }
}
