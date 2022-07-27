namespace _1295_Find_Numbers_with_Even_Digits
{
    internal class Program
    {
        static int Calculation_Digits(int num)
        {
            /* Tính số lượng ký tự num
             * Chia dư input cho 10 
             * => số lần chia khi đạt được kết quả là 0 => số lượng ký tự 
             */
            var result = num;
            int count = 0;
            while (result != 0)
            {
                result = num / 10;
                num = result;
                count++;
            }
            return count;
        }
        static int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                var count_digits = Calculation_Digits(num);
                if (count_digits % 2 == 0) // digits là số chẳn
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1295_Find_Numbers_with_Even_Digits");
            int[] nums = { 1, 20, 3, 40 };
            Console.WriteLine(FindNumbers(nums));
            Console.Read();
        }
    }
}