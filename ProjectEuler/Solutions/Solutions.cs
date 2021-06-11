using System.Linq;
using System.Collections.Generic;

using Utility;

namespace ProjectEuler
{
    public class Solutions
    {
        Multiples multiples = new Multiples();
        Patterns patterns = new Patterns();

        public int Problem1()
        {
            return multiples.MultiplesBelowAndOf(1000, 3, 5).Sum();
        }

        public int Problem2()
        {
            List<int> a = patterns.Fibonacci_ElementSizeN(4000000);

            int total = 0;
            foreach (var i in a)
            {
                if (i % 2 == 0)
                    total += i;
            }

            return total;
        }

        public long Problem3()
        {
            long n = 600851475143;
            List<long> primeFactors = multiples.PrimeFactors(n);
            return primeFactors.Max();
        }

        public int Problem4()
        {
            int max = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (patterns.IsPalindrome(product) && product > max)
                        max = product;
                }
            }

            return max;
        }

        public int Problem5()
        {
            int[] array = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 2520; i < 2147483647; i += 2520)
            {
                if (multiples.DivisibleBy(i, array))
                    return i;
            }

            return 0;
        }

        public long Problem6()
        {
            return multiples.SquareOfSum(100) - multiples.SumOfSquares(100);
        }

        public long Problem7()
        {
            int count = 1;
            for (int i = 2; i < 2147483647; i++)
            {
                if (multiples.IsPrime_Prime(i))
                {
                    if (count == 10001)
                        return i;
                    count++;
                }
            }

            return 0;
        }

        public long Problem8()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\thomb\source\repos\cs.projecteuler\ProjectEuler\Solutions\files\Problem8.txt");
            char [] number = file.ReadToEnd().ToCharArray();
            int[] intArray = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                intArray[i] = int.Parse(number[i].ToString());
            }

            long max = 0;

            int start = 0;
            int end = 13;

            while (end != 1000)
            {
                long total = 1;
                for (int i = start; i < end; i++)
                {
                    total *= intArray[i];
                }

                if (total > max)
                    max = total;

                start++;
                end++;
            }

            return max;
        }

        public int Problem9()
        {
            return patterns.PythagoreanTripletProduct(1000);
        }

        public long Problem10()
        {
            long sum = 2;
            int count = 1;

            for (int i = 3; i < 2000000; i++)
            {
                if (multiples.IsPrime_Prime(i))
                {
                    sum += i;
                    count++;
                }
            }

            return sum;
        }
    }
}
