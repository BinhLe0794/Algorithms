using System.Diagnostics;

Console.WriteLine("Start Binary Search Example 704");
static int BinarySearch(int[] a, int key)
{
   var n = a.Length;
   var left = 0;
   var right = n - 1;
   while (left <= right)
   {
      int mid = (left + right) / 2;
      Console.WriteLine("{0},{1},{2},{3}" ,n,left, right,mid);
      if( key == a[mid] )
      {
         return mid;
      }
      else if( key < a[mid] )
      {
         right = mid - 1;
      }
      else if( key > a[mid] )
      {
         left = mid + 1;
      }
   }
   return -1;
}
static int RecursionBinarySearch(int[] a, int key, int left, int right)
{
   if( left > right )
   {
      return -1;
   }
   var mid = (left + right) / 2;
   if( key == a[mid] )
   {
      return mid;
   }
   else if( key < a[mid] )
   {
      return RecursionBinarySearch(a, key, left, mid - 1);
   }
   else // if( key > a[mid] )
   {
      return RecursionBinarySearch(a, key, mid + 1, right);
   }
}
var a = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
var key = 10;
Stopwatch stopwatch1 = new Stopwatch();
Stopwatch stopwatch2 = new Stopwatch();
stopwatch1.Start();
Console.WriteLine($"Index of {key} using Iterate: " + BinarySearch(a, key));
stopwatch1.Stop();
Console.WriteLine("Elapsed Time is {0} ms", stopwatch1.ElapsedMilliseconds);
stopwatch2.Start();
Console.WriteLine($"Index of {key} using Recursion: " + RecursionBinarySearch(a, key, 0, a.Length - 1));
stopwatch2.Stop();
Console.WriteLine("Elapsed Time is {0} ms", stopwatch2.ElapsedMilliseconds);
Console.Read();