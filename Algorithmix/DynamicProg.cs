using System;
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
        */
        public static int countCombinationStep(int nbMarche)
        {
            if (nbMarche < 0) return 0;
            if (nbMarche == 0) return 1;
            return countCombinationStep(nbMarche - 1) + countCombinationStep(nbMarche - 2) + countCombinationStep(nbMarche - 3);
        }

        /*
        Un tableau de n entier distinct trié donnant un accès à un indice A[1 ... n-1], il existe un indice magique tel que A[i] = i.
        Trouver si il existe l'indice magique avec un algorithme.
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
