using Common;
using System.Text;

namespace _1662_Check_String_Arrays_Equivalent
{// Next Chalenge 2060
    internal class Program
    {
        static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string result1 = string.Join("", word1);
            string result2 = string.Join("", word2);
            if (result1.Length != result2.Length)
            {
                return false;
            }
            for (int i = 0; i < result1.Length; i++)
            {
                if (result1[i] != result2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ArrayStringsAreEqual_2(string[] word1, string[] word2)
        {
            StringBuilder sb1 = new();
            StringBuilder sb2 = new();

            foreach (var word in word1)
            {
                sb1.Append(word);

            }

            foreach (var word in word2)
            {
                sb2.Append(word);
            }

            if (sb1.Length != sb2.Length)
                return false;

            if (sb1.ToString() != sb2.ToString())
                return false;

            return true;
        }
        static void Main(string[] args)
        {
            string[] word1 = { "abc", "d", "defg" };
            string[] word2 = { "abcddefg" };
            var result = ArrayStringsAreEqual(word1, word2);
            ArrayExtensions.PrintStringArray(word1);
            Console.WriteLine();
            ArrayExtensions.PrintStringArray(word2);
            Console.WriteLine();
            if (result)
            {
                Console.WriteLine($"Word 1 == Word 2");
            }
            else
            {
                Console.WriteLine($"Word 1 != Word 2");
            }
            Console.Read();
        }
    }
}