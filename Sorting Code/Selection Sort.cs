using System;

public class SelectionSortExample
{
    public static void Main(string[] args)
    {
        int[] arr = { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
        Console.WriteLine("Initial array:");
        PrintArray(arr);

        SelectionSort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Swap the found minimum element with the first element
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}