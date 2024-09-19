using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 7;
        int index = Array.BinarySearch(numbers, target);

        if (index >= 0)
            Console.WriteLine($"Element found at index {index}");
        else
            Console.WriteLine("Element not found");
    }
}
