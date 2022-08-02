// See https://aka.ms/new-console-template for more information

static void Recursion(int[] arr, int index)
{
    if (index < 0 || index >= arr.Length)
    {
        return;
    }
    Recursion(arr, index + 1);
    Console.WriteLine("Element : " + arr[index]);
}

Console.WriteLine("Hello, World!");

int[] arr = new int[5] { 1, 2, 3, 4, 5 };

Recursion(arr, 0);

Console.Read();

