using System;

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

        /*
         * 
         * Problem : determine if any 3 integers in an array sum to 0. 
         * Complexity : O(n²)
         */
        public static void threeSumV1(int [] tab)
        {
            // quicksort : O(n log n)
            Array.Sort<int>(tab);

            for (int i = 0; i != tab.Length; i++)
            {
                int k = 0;
                int j = tab.Length-1;
                while ( k < j && k < tab.Length && j < tab.Length && j > 0)
                {

                    if (k == i) {
                        k++;
                        continue;
                    }

                    if (j == i) {
                        j--;
                        continue;
                    }

                    if (tab[i] == (tab[k] + tab[j]))
                    {
                        Console.WriteLine("Found : " + tab[i] + " : " + tab[k] + " : " + tab[j]);
                    }

                    if (tab[k] > tab[i]) j--;
                    else k++;
                }
            }
        }
    }
}
