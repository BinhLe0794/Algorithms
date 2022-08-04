using Common;

namespace _912_Sort_Array
{
    internal class Program
    {
        static int[] MergeSort(int[] nums, int left, int right)
        {
            // Xet dieu kien dung
            if (left > right)
            {
                return new int[nums.Length];
            }
            else if (left == right) // Chia tới khi chỉ còn 1 phần  tử
            {
                return new int[] { nums[left] };
            }
            // Tách ra 2 mảng
            int mid = (left + right) / 2; 
            int[] left_array = MergeSort(nums, left, mid);
            int[] right_array = MergeSort(nums, mid + 1, right);
            //Trộn vào
            var maxlength = left_array.Length + right_array.Length; // độ dài mảng trả về 
            int[] result = new int[maxlength]; // khai báo mảng trả về
            var result_index = 0; // index của mảng trả về

            var left_array_index = 0;
            var right_array_index = 0;

            while (result_index < maxlength) // Khi mảng merge chưa đầy
            {
                // Khi 2 mảng vẫn còn phần tử
                if (left_array_index < left_array.Length && right_array_index < right_array.Length)
                {
                    if (left_array[left_array_index] < right_array[right_array_index])
                    {
                        result[result_index++] = left_array[left_array_index++];
                    }
                    else
                    {
                        result[result_index++] = right_array[right_array_index++];
                    }
                } // mảng bên trái còn phần tử
                else if (left_array_index < left_array.Length)
                {
                    result[result_index++] = left_array[left_array_index++];
                }// mảng bên phải còn phần tử
                else if (right_array_index < right_array.Length)
                {
                    result[result_index++] = right_array[right_array_index++];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort using Recursion");

            var result = MergeSort(ArrayCollection.unSortedArray, 0, ArrayCollection.unSortedArray.Length - 1);

            ArrayExtensions.PrintArray(result);

            Console.Read();
        }
    }
}