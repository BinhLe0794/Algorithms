using Common;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    internal class Program
    {
        static void Sort(ref int[] nums)
        {
            var maxLength = nums.Length;
            for (int i = 1; i < maxLength - 1; i++) // nếu chỉ có 1 phần tử thì đã sorted
            {
                int insert_value = nums[i];
                Console.WriteLine("\n");
                Console.WriteLine("Insert Value : " + insert_value);
                int start_position = i - 1;
                Console.WriteLine("Position : " + start_position);
                // đẩy giá trị của mảng đã sắp sếp tại vị trị tương ứng về bên phải
                // nếu insert_value bé hơn current_value
                while (start_position >= 0 && nums[start_position] > insert_value)
                {

                    nums[start_position + 1] = nums[start_position];
                    start_position--;
                }
                Console.WriteLine($"Find Position {start_position}");
                // insert value vào vị trí tìm thấy vì index sẽ giảm về -1 nên cần + 1
                nums[start_position + 1] = insert_value;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var array = ArrayCollection.unSortedArray;

            //ArrayExtensions.PrintArray(array);
            //Console.WriteLine("\n");
            //Sort(ref array);
            //Console.WriteLine("\n");

            //ArrayExtensions.PrintArray(array);

            //SingleListNode node1 = new(1);
            //SingleListNode node2 = new(2);
            //node1.next = node2;

            //Console.WriteLine(node1.next.data);

            Console.Read();

        }
    }
}