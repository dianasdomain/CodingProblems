using System;
using CommonItem;
using ReverseString;
using MergeSortedArrays;

class Program
{
    public static void Main(string[] args)
    {
        // Common items between 2 arrays
        int[] array1 = { 1, 2, 3, 4 };
        int[] array2 = { 5, 6, 7, 8 };
        int[] array3 = { 1, 5, 6, 7 };

        bool result = CommonItemMethods.ContainsCommonItem(array1, array2);
        Console.WriteLine(result);

        bool result2 = CommonItemMethods.ConatinsCommonItem2(array1, array3);
        Console.WriteLine(result2);

        // Reverse string
        string inputString = "anaiD si eman yM !iH";
        string result3 = ReverseStringMethods.ReverseString(inputString);
        Console.WriteLine(result3);

        string result4 = ReverseStringMethods.ReverseString2(inputString);
        Console.WriteLine(result4);

        // Merge sorted arrays
        int[] array4 = { 0, 3, 4, 31 };
        int[] array5 = { 4, 6, 30 };
        int[] array6 = { };

        int[] result5 = MergeSortedArraysMethods.MergeSortedArrays(array4, array5);
        int[] result6 = MergeSortedArraysMethods.MergeSortedArrays(array4, array6);
        int[] result7 = MergeSortedArraysMethods.MergeSortedArrays(array5, array6);

        Console.WriteLine(string.Join(", ", result5));
        Console.WriteLine(string.Join(", ", result6));
        Console.WriteLine(string.Join(", ", result7));
    }
}