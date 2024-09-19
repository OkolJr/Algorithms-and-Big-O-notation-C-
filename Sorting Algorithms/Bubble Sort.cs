using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 8, 4, 2 };
        BubbleSort(array);

        Console.WriteLine("Sorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
