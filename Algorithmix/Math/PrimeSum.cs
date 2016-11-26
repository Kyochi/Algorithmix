using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmix.Math
{
    /*
     * Given an even number ( greater than 2 ), return two prime numbers whose sum will be equal to given number.
     */
    class PrimeSum
    {
        public List<int> primesum(int A)
        {
            int[] prime = new int[A + 1];
            for (int n = 0; n <= A; n++) prime[n] = 1;

            prime[0] = 0;
            prime[1] = 0;

            // get prime numbers
            for (int i = 2; i <= A; i++)
            {

                if (prime[i] == 1)
                {
                    for (int j = 2; j * i <= A; j++)
                    {
                        prime[j * i] = 0;
                    }
                }
            }

            List<int> prime2 = new List<int>();
            Dictionary<int, int> m = new Dictionary<int, int>();

            // map of prime numbers
            for (int i = 0; i != prime.Length; i++) if (prime[i] != 0) { prime2.Add(i); m.Add(i, 1); }

            List<int> res = new List<int>();

            // check if prime sum exists
            for (int i = 0; i != prime2.Count(); i++)
            {
                if (m.ContainsKey(A - prime2[i]))
                {
                    res.Add(prime2[i]);
                    res.Add(A - prime2[i]);
                }
            }
            return new List<int> { res[0], res[1] };
        }
    }
}
