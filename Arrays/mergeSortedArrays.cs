// Given 2 sorted arrays, create a function that merges these 2 arrays into a single sorted array

// Test cases:
// 1. [0, 3, 4, 31], [4, 6, 30] -> [0, 3, 4, 4, 6, 30, 31]
// 2. [0, 3, 4, 31], [] -> [0, 3, 4, 31]
// 3. [], [4, 6, 30] -> [4, 6, 30]

// I have 2 parameters - arrays
// Return a new array

// Ask interviewer how large the arrays are going to get and if the arrays can be empty

using System;

namespace MergeSortedArrays
{
  public class MergeSortedArraysMethods
  {
      // O(n + m) time complexity
      // O(n + m) space complexity
      public static int[] MergeSortedArrays(int[] array1, int[] array2){
        int[] mergedArray = new int[array1.Length + array2.Length];
        int indexArray1 = 0;
        int indexArray2 = 0;
        int indexMergedArray = 0;
  
        if(array1.Length == 0){
          return array2;
        }
        if(array2.Length == 0){
          return array1;
        }

        // Merge arrays while there are elements in both arrays
        while (indexArray1 < array1.Length && indexArray2 < array2.Length)
        {
            if (array1[indexArray1] < array2[indexArray2])
            {
                mergedArray[indexMergedArray++] = array1[indexArray1++];
            }
            else
            {
                mergedArray[indexMergedArray++] = array2[indexArray2++];
            }
        }

        // Copy remaining elements from array1, if any
        while (indexArray1 < array1.Length)
        {
            mergedArray[indexMergedArray++] = array1[indexArray1++];
        }

        // Copy remaining elements from array2, if any
        while (indexArray2 < array2.Length)
        {
            mergedArray[indexMergedArray++] = array2[indexArray2++];
        }
  
        return mergedArray;
      }
  }
}