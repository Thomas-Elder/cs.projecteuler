using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class Patterns
    {

        /// <summary>
        /// Returns the Fibonacci sequence in a list of ints, up to n elements.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> Fibonacci_LengthN(int n)
        {
            List<int> sequence = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    sequence.Add(1);
                else
                    sequence.Add(sequence[i-2] + sequence[i-1]);
            }

            return sequence;
        }

        /// <summary>
        /// Returns the Fibonacci sequence in a list of ints, with the highest value
        /// in the sequence being less than n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> Fibonacci_ElementSizeN(int n)
        {
            List<int> sequence = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                    sequence.Add(1);
                else
                    sequence.Add(sequence[i - 2] + sequence[i - 1]);

                if (sequence[i] > n)
                    break;
            }

            return sequence;
        }

        /// <summary>
        /// Compares a string to itself for palindromicness.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool IsPalindrome(int a)
        {
            char[] c = a.ToString().ToCharArray();

            int i = 0; 
            int j = c.Length -1;

            while(true)
            {
                if (c[i] != c[j])
                    break;

                if (i >= j)
                    return true;

                i++;
                j--;
            }  

            return false;
        }

        /// <summary>
        /// Compares a string to itself for palindromicness.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool IsPalindromeSplit(int a)
        {
            char[] c = a.ToString().ToCharArray();
            int half = (int)(Math.Floor((double)(c.Length / 2)));

            char[] c1 = c.Take(half).ToArray();
            char[] c2 = c.Skip(half).ToArray();
            Array.Reverse(c2);

            for (int i = 0; i < c1.Length; i++)
            {
                if (c1[i] != c2[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Returns the product of a Pythagorean Triplet whose sum is == n.
        /// Returns 0 if there exists no Pythagorean Triplet whose sum is == n.
        /// 
        /// A Pythagorean Triplet is 3 integers a , b , c who satisfy:
        /// 'a < b < c' &&
        /// a^2 + b^2 = c^2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int PythagoreanTripletProduct(int n)
        {
             // 3, 4, 5 is the smallest pythagorean triplet, so we can start here 
            int a = 0;
            int b = 0;

            // Now we need to check values for a, b, c such that the sum is <= 1000
            for (int i = 3; i < n; i++)
            {
                for (int j = 4; j < n; j++)
                {
                    // Calculate c
                    int c = (int)Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));

                    // Check if a b c is a Pythagorean triplet, with a sum <= n
                    if (PythagoreanTriplet(i, j, c) && i + j + c == n)
                    {
                        a = i;
                        b = j;
                    }
                }
            }

            return a * b * (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        /// <summary>
        /// Returns true if the 3 integers passed are a Pythagorean Triplet.
        /// 
        /// A Pythagorean Triplet is 3 integers a , b , c who satisfy:
        /// 'a < b < c' &&
        /// a^2 + b^2 = c^2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool PythagoreanTriplet(int a, int b, int c)
        {
            // If a^2 + b^2 = c^2 AND c > b > a, return true
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && c > b && b > a)
                return true;
                
            return false;
        }
    }
}
