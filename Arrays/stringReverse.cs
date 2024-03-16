// Reverse a string
// Initial string = "anaiD si eman yM !iH"
// Desired string = "Hi! My name is Diana"

using System;

namespace ReverseString
{
    public class ReverseStringMethods
    {
        // Brute force approach:
        // O(n) time complexity
        // O(n) space complexity
        public static string ReverseString(string inputString)
        {
            string result = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }

            return result;
        }

        // Better approach:
        // O(n) time complexity
        // O(n) space complexity
        // Using built-in methods like Array.Reverse promotes code maintainability and readability.
        public static string ReverseString2(string inputString)
        {
            if (inputString.Length != 0)
            {
                char[] charArray = inputString.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            return "";

        }
    }
}