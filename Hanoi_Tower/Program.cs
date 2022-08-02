static void towerofHanoi(int n, char from_col, char to_col, char help_col)
{
   int step = 0;
   if (n == 1)
   {
      Console.WriteLine($"{step++} Take disk 1 from {from_col} to {to_col}");
      return;
   }

   towerofHanoi(n - 1, from_col, help_col, to_col);

   Console.WriteLine($"Take disk from {from_col} to {to_col}");

   towerofHanoi(n - 1, help_col, to_col, from_col);
}

Console.WriteLine("Start Hanoi Tower");
towerofHanoi(3, 'A', 'B', 'C');