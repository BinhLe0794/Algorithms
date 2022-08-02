// See https://aka.ms/new-console-template for more information
/* Euclid Algorithms
 * 
 */
int Eculid(int a, int b)
{
   int r = 0;
   int max = a;
   int min = b;
   if (a < b)
   {
      (max, min) = (min, max);
   }

   r = max % min;
   if (r == 0)
   {
      return b;
   }
   else
   {
      return Eculid(b, r);
   }
}
//smallest common multiple
int SCM(int a, int b)
{
   int UCLN = Eculid(a, b);
   return (a * b) / UCLN;
}


Console.WriteLine("Start Program");

//Console.WriteLine("UCLN is " + Eculid(462, 1071));
Console.WriteLine("BCNN is " + SCM(25, 20));

Console.Read();