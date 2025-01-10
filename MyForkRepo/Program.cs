using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 3, 8, 4, 2 };
        BubbleSort(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        // Incorrect: Outer loop should run n-1 times, not n times
        for (int i = 0; i < n; i++)
        {
            // Incorrect: Inner loop should run up to n - 1 - i, not n
            for (int j = 0; j < n; j++)
            {
                // Incorrect comparison: Should be arr[j] > arr[j+1]
                if (arr[j] < arr[j + 1])
                {
                    // Swap elements if they are out of order
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}