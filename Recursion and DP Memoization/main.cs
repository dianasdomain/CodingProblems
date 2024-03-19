using System;
using Factorial;
using Fibonacci;

class Program
{
    public static void Main(string[] args)
    {
        int factorialResult = FactorialMethods.FactorialRecursive(5);
        int factorialResult2 = FactorialMethods.FactorialIterative(2);

        Console.WriteLine("Recursive factorial result: " + factorialResult);
        Console.WriteLine("Iterative factorial result: " + factorialResult2);
        Console.WriteLine("==============================");

        int fibonacciResult = FibonacciMethods.FibonacciRecursive(4);
        int fibonacciResult2 = FibonacciMethods.FibonacciIterative(8);
        int fibonacciResult3 = FibonacciMethods.FibonacciRecursiveImproved(4);

        Console.WriteLine("Recursive fibonacci result: " + fibonacciResult);
        Console.WriteLine("Iterative fibonacci result: " + fibonacciResult2);
        Console.WriteLine("Improved recursive fibonacci result: " + fibonacciResult3);
        Console.WriteLine("==============================");


    }
}