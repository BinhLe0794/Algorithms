using Common;

namespace _88_Merge_Sorted_Array
{
    internal class Program
    {
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            /* m,n : số phần tử hiện tai của nums1, nums2
             * nums1.length = m + n
             * nums2.length = n
             */
            foreach (var num in nums2)
            {
                // chèn num vào nums1
                Insert(num, nums1, m);
                m++;
            }
        }

        private static void Insert(int insertValue, int[] insertArray, int m)
        {
            bool isFinded = false;
            for (int i = 0; i < m; i++) // duyệt mảng từ đầu tới vị trị có giá trị 
            {
                if (insertArray[i] > insertValue)// giá trị chèn nhỏ hơn giá trị trong mảng
                {
                    isFinded = true;
                    for (int j = m - 1; j >= i; j--) // duyệt mảng từ vị trí cuối trở lên
                    {
                        // dịch phần tử xuống 1 đơn vị
                        insertArray[j + 1] = insertArray[j];
                    }
                    // gán giá trị được chèn vào trị trí trống
                    insertArray[i] = insertValue;
                    break;
                }
            }
            if (!isFinded) // nếu không tìm thấy thì chèn ở vị trí cuối cùng
            {
                insertArray[m] = insertValue;
            }
        }
        private static void Merge_2(int[] num1, int m, int[] num2, int n)
        {
            int index = m + n - 1; // xác định index cuối cùng của merge array
            m--; // index cuối cùng của num1
            n--;// index cuối cùng của num2

            while (n >= 0) // duyệt hết num2
            {
                // nếu chưa duyệt hết num1 và giá trị của num1 lớn hơn num2
                if (m >= 0 && num1[m] > num2[n])
                    num1[index] = num1[m--];// chèn vào trị trí cuối cùng của num1 + giảm index của num1 
                else // nếu giá trị của mảng 2 lớn hơn mảng 1 thì chèn giá trị của mảng 2 vào mảng 1 + giảm index của num2
                    num1[index] = num2[n--];
                // cuối cùng thì lùi index của merge_array 
                index--;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            //Merge(nums1, 3, nums2, 3);
            Merge_2(nums1, 3, nums2, 3);
            ArrayExtensions.PrintArray(nums1);
            Console.Read();
        }
    }
}