using System;
using System.Collections.Generic;
using System.IO;
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

        public static Vector Parse(string s)
        {
            string[] xy = s.Split (',');

            if(xy.Length == 2 && double.TryParse(xy[0], out double x) && double.TryParse(xy[1],out double y)) 
                {
           
                return new Vector (x,y);
            }
            else { return new Vector (double.NaN,double.NaN); }
        }
    }
}
