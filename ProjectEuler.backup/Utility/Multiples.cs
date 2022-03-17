using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public class Multiples
    {
        /// <summary>
        /// Returns true if n is divisible by all integers in a
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool DivisibleBy(int n, int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (n % a[i] != 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Returns a list of integers lower than 'n', which are multiples of 'a'.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public List<int> MultiplesBelowAndOf(int n, int a)
        {
            List<int> result = new List<int>();

            for (int i = a; i < n; i++)
            {
                if (i % a == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a list of integers lower than 'n', which are multiples of 'a' or 'b'.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public List<int> MultiplesBelowAndOf(int n, int a, int b)
        {
            List<int> result = new List<int>();

            for (int i = a < b ? a : b; i < n; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime_Naive(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime_SqrtN(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime_Prime(int n)
        {

            // Handle trivial cases 
            if (n.Equals(2) || n.Equals(3)) { return true; }
            else if (n <= 1 || (n % 2).Equals(0) || (n % 3).Equals(0)) { return false; }

            // Then we can start at 5, and run til sqrt(n), anything higher we run into the 
            // complementary factors of one's we've already found. 
            for (int i = 5; i <= Math.Sqrt(n); i += 6)
            {
                if ((n % i).Equals(0) || (n % (i + 2)).Equals(0))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime_Prime(long n)
        {

            // Handle trivial cases 
            if (n.Equals(2) || n.Equals(3) || n.Equals(5)) { return true; }
            else if (n <= 1 || (n % 2).Equals(0) || (n % 3).Equals(0)) { return false; }

            // Then we can start at 5, and run til sqrt(n), anything higher we run into the 
            // complementary factors of one's we've already found. 
            for (int i = 5; i <= Math.Sqrt(n); i += 6)
            {
                if ((n % i).Equals(0) || (n % (i + 2)).Equals(0))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime(int n)
        {
            for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks n for primeness
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime(long n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns a list of factors of n which are prime.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> PrimeFactors(int n)
        {
            List<int> primeFactors = new List<int>();

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (IsPrime_Prime(i))
                        primeFactors.Add(i);

                    if(IsPrime_Prime(n / i))
                        primeFactors.Add(n / i);
                }
            }

            return primeFactors;
        }

        /// <summary>
        /// Returns a list of factors of n which are prime.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<long> PrimeFactors(long n)
        {
            List<long> primeFactors = new List<long>();

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (IsPrime_Prime(i))
                        primeFactors.Add(i);

                    if (IsPrime_Prime(n / i))
                        primeFactors.Add(n / i);
                }
            }

            return primeFactors;
        }

        /// <summary>
        /// Returns the sum of squares for all integers up to and including n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long SumOfSquares(long n)
        {
            long sum = 0;
            for (long i = 0; i <= n; i++)
                sum += i * i;

            return sum;
        }

        /// <summary>
        /// Returns the square of the sum of all integers up to and including n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long SquareOfSum(long n)
        {
            long sum = 0;
            for (long i = 0; i <= n; i++)
                sum += i;

            return sum * sum;
        }
    }

    
}
