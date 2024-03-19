// Write a function that calculates the factorial of a number.

using System;

namespace Factorial
{
    public class FactorialMethods
    {
        // O(n) time complexity
        public static int FactorialRecursive(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * FactorialRecursive(number - 1);
        }

        // O(n) time complexity
        public static int FactorialIterative(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}