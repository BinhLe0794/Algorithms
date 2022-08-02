int Factorial(int n)
{
   if (n == 0)
   {
      Console.WriteLine($"n = {n} - Finished");
      return 1;
   }
   Console.WriteLine($"n = {n} - Let's go");
   return n * Factorial(n - 1);
}

Console.WriteLine("Start Factorial Math !");
Console.WriteLine("Factorial of 5 is : " + Factorial(5));
Console.Read();