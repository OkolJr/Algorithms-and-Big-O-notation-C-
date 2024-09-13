using MergeSort;

int[] arr = { 5, 2, 4, 9, 1, 13, 3, 8, 6, 7 };

foreach(var a in arr)
{
    Console.WriteLine(a);
}

MergeSortImplementation.MergeSort(arr, 0, arr.Length - 1);

foreach (var a in arr)
{
    Console.WriteLine(a);
}