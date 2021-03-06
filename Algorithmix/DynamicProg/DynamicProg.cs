﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix
{
    class DynamicProg
    {
        /*
        Un enfant cherche à monter un escalier de N marches, à chaque pas il peut monter 1, 2 ou 3 marche en d'un coup
        combien de combinaison sont possibles pour arriver en haut ?
        step 1 : Brute force 
        step 2 : DP algorithm memoization
        */

        public static Int64 countCombinationStep(int nbMarche, Int64[] memoTab)
        {
            if (nbMarche < 0)
            {
                return 0;
            }
            if (nbMarche == 0)
            {
                memoTab[nbMarche] = 1;
                return 1;
            }

            if (memoTab[nbMarche] == -1)
            {
                memoTab[nbMarche] = countCombinationStep(nbMarche - 1, memoTab) + countCombinationStep(nbMarche - 2, memoTab) + countCombinationStep(nbMarche - 3, memoTab);
                return memoTab[nbMarche];
            }
            return memoTab[nbMarche];
        }

        public static Int64 callCountComb(int nStep)
        {
            Int64[] tab = new Int64[nStep + 1];
            for (int n = 0; n != tab.Length; n++)
            {
                tab[n] = -1;
            }

            return countCombinationStep(nStep, tab);
        }
        
        // step 1 : bruteforce
        public static int BruteCountCombinaisonStep(int n)
        {
            if (n < 0) return 0;
            if (n == 0) return 1;

            return BruteCountCombinaisonStep(n - 1) + BruteCountCombinaisonStep(n - 2) + BruteCountCombinaisonStep(n - 3);
        }


        /*
        Un tableau de n entier distinct trié donnant un accès à un indice A[1 ... n-1], il existe un indice magique tel que A[i] = i.
        Trouver si il existe l'indice magique avec un algorithme.
        Etape 1 : bruteforce algo
         */
        public static int giveMeMagicIndex(int[] array, int I)
        {
            if (I == array.Length - 1) return int.MinValue;
            if (array[I] == I) return I;
            I++;
            return giveMeMagicIndex(array, I = I++);
        }


         
    }
}
