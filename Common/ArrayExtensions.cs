using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ArrayExtensions
    {
        public static void PrintArray(int[] array)
        {
            Console.Write($"Array Length {array.Length} : ");
            foreach (var item in array)
            {
                Console.Write($"{item} \t");
            }
        }
    }
}
