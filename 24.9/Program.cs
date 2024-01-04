using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 2);
            Vector v2 = new Vector(3, 3);

            Vector v3 = new Vector(4,4);

           
            Vector sommaV1V2 = v1.Somma(v2);
            Vector sommaV1V3 = v1.Somma(v3);


            Console.WriteLine("v1: " + v1);
            Console.WriteLine("v2: " + v2);
            Console.WriteLine("v3: " + v3);
            Console.WriteLine("Somma v1 e v2: " + sommaV1V2);
            Console.WriteLine("Somma v1 e v3: " + sommaV1V3);
        }
    }
}
