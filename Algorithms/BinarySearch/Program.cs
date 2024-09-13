using BinarySearch;

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var index = BinarySearchImplementation.BinarySearch(arr, 9);

if (index == -1)
{
    Console.WriteLine("Searched index of element hasn't been found");
} 
else
{
    Console.WriteLine($"Searched index of element is: {index}");
}
