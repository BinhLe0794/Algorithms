namespace _414_Third_Maximum_Number
{
    internal class Program
    {
        public static int ThirdMax(int[] nums)
        {
            long[] maxArr = { long.MinValue, long.MinValue, long.MinValue };

            for (int i = 0; i < nums.Length; i++)
            {
                Insert(maxArr, nums[i]);
            }
            if (maxArr[2] == long.MinValue)
            {
                return (int)maxArr[0];
            }

            return (int)maxArr[2];
        }

        private static void Insert(long[] maxArr, int val)
        {
            int i = 0;
            while (i < maxArr.Length)
            {
                if (val == maxArr[i])
                {
                    return;  // nếu bị trùng
                }
                else if (val > maxArr[i])
                {
                    break; // tiến hành chèn
                }
                else // val < maxArray[i]
                {
                    i++;
                }
            }
            // 3 2 1 | 1
            if (i < maxArr.Length)
            {
                for (int j = maxArr.Length - 2; j >= i; j--)
                {
                    maxArr[j + 1] = maxArr[j];
                }
                maxArr[i] = val;
            }
        }
        public int ThirdMax_Best(int[] nums)
        {
            long max1 = Int64.MinValue, max2 = Int64.MinValue, max3 = Int64.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2 && nums[i] < max1)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] > max3 && nums[i] < max2)
                    max3 = nums[i];
            }

            return max3 == Int64.MinValue ? (int)max1 : (int)max3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = new int[] { 6, 9, 10, 1, 4, 7 };
            var thirdMax = ThirdMax(nums);
            Console.WriteLine("The Third Max is " + thirdMax.ToString());
            Console.Read();
        }
    }
}