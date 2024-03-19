// Given a number N, return the index value of the Fibonacci sequence, where the sequence is:
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 ...
// The pattern of the sequence is that each value is the sum of the 2 previous values
// Return Nth index value of the Fibonacci sequence

using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciMethods
    {
        // O(2^n) time complexity - exponential
        public static int FibonacciRecursive(int number)
        {
            // Base case
            if (number < 2)
            {
                return number;
            }

            return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
        }

        // Time complexity: O(n) linear
        // Space complexity: O(n) - store the sequence in an array
        public static int FibonacciIterative(int number)
        {
            int[] fibonacciArray = new int[number + 1];
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }
            return fibonacciArray[number];
        }

        // Better solution for recursive approach
        // O(n) time complexity 
        // Dynamic programming - memorization 
        // Cache the values so that we don't have to recalculate them

        public static Dictionary<int, int> copy = new Dictionary<int, int>();

        public static int FibonacciRecursiveImproved(int number)
        {
            if (copy.ContainsKey(number))
            {
                return copy[number];
            }

            if (number < 2)
            {
                return number;
            }
            copy.Add(number, FibonacciRecursiveImproved(number - 1) + FibonacciRecursiveImproved(number - 2));

            return copy[number];
        }
    }
}