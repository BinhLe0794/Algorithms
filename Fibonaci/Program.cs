static int Fibonaci(int n)
{
   // Base Condition
   if (n <= 2)
   {
      return 1;
   }
   var sum = Fibonaci(n - 1) + Fibonaci(n - 2);
   Console.WriteLine($"{sum} is sum of: {n - 1} and {n - 2}");
   return sum;
}
static int Fibonaci_2(int n)
{
   int[] F = new int[n + 1];
   F[1] = 1;
   F[2] = 1;
   for (int i = 3; i <= n; i++)
   {
      F[i] = F[i - 1] + F[i - 2];
   }
   return F[n];
}
Console.WriteLine("Start Program Fibonaci of n");

Console.WriteLine(Fibonaci(10));

Console.WriteLine("Khu De Quy: " + Fibonaci_2(10));