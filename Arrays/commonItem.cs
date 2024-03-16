// Given 2 arrays, create a function that let's a user know (true/false) whether these two arrays contain any common items

// Test cases:
// 1. [1,2,3,4], [5,6,7,8] -> false
// 2. [1,2,3,4], [1,2,3,4] -> true
// 3. [1,2,3,4], [1,6,7,8,9] -> true

// I have 2 parameters - arrays
// Return true or false

// Ask interviewer how large the arrays are going to get and if the arrays can be empty

using System.Collections.Generic;

namespace CommonItem
{
    public class CommonItemMethods
    {
        // Brute force approach:
        // O(n*m) because we are looping through both arrays and they are not the same size
        // O(1) space complexity
        public static bool ContainsCommonItem(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Better approach:
        // O(n + m)
        // O(n) space complexity)
        public static bool ConatinsCommonItem2(int[] array1, int[] array2)
        {
            // Store the elements of array1 in a HashSet
            HashSet<int> hashSet = new HashSet<int>(array1);

            // Check if the elements of array2 exist in the HashSet
            foreach (int item in array2)
            {
                if (hashSet.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}