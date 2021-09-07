// C# program to find prime factorization of a
// number n in O(Log n) time with precomputation
// allowed.
using System;
using System.Collections;

class GFG
{
    static int MAXN = 100001;

    // stores smallest prime factor for every number
    static int[] spf = new int[MAXN];

    // Calculating SPF (Smallest Prime Factor) for every
    // number till MAXN.
    // Time Complexity : O(nloglogn)
    static void sieve()
    {
        spf[1] = 1;
        for (int i = 2; i < MAXN; i++)

            // marking smallest prime factor for every
            // number to be itself.
            spf[i] = i;

        // separately marking spf for every even
        // number as 2
        for (int i = 4; i < MAXN; i += 2)
            spf[i] = 2;

        for (int i = 3; i * i < MAXN; i++)
        {
            // checking if i is prime
            if (spf[i] == i)
            {
                // marking SPF for all numbers divisible by i
                for (int j = i * i; j < MAXN; j += i)

                    // marking spf[j] if it is not
                    // previously marked
                    if (spf[j] == j)
                        spf[j] = i;
            }
        }
    }

    // A O(log n) function returning primefactorization
    // by dividing by smallest prime factor at every step
    static ArrayList getFactorization(int x)
    {
        ArrayList ret = new ArrayList();
        while (x != 1)
        {
            ret.Add(spf[x]);
            x = x / spf[x];
        }
        return ret;
    }

    // Driver code
    public static void Main()
    {
        // precalculating Smallest Prime Factor
        sieve();
        int x = 12246;
        Console.Write("prime factorization for " + x + " : ");

        // calling getFactorization function
        ArrayList p = getFactorization(x);

        for (int i = 0; i < p.Count; i++)
            Console.Write(p[i] + " ");
        Console.WriteLine("");
    }
}