using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix
{
    class Algo
    {
        public static double cubicSqrd(double n)
        {
            return (System.Math.Pow(n, (1 / 3)));
            
        }

        public static void computeEqualityPowV1 ()
        {
            int n = 100;
            for ( double a = 0; a != n; a++ )
            {
                for (double b = 0; b != n; b++)
                {
                    for (double c = 0; c != n; c++)
                    {
                        
                        double d = cubicSqrd(Math.Pow(a, 3) +  Math.Pow(b, 3) + (-1 * Math.Pow(c, 3)));
                        
                        if ((Math.Pow(a, 3) + Math.Pow(b, 3)) ==  (Math.Pow(c, 3) + Math.Pow(d, 3)))
                        {
                            Console.WriteLine("Trouvé : a=" + a + " b=" + b + " c=" + c + " d=" + d);
                        }
                        
                    }
                }
            }
            Console.WriteLine(" Fini !");
        }
    }
}
