using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MergeSort
{
    public static class MergeSortImplementation
    {
        public static void MergeSort(int[] unsortedArray, int start, int end)
        {
            if (start < end) // { 5, 2, 4, 9, 1, 13, 3, 8, 6, 7 };
            {
                // Find the middle point
                int middle = start + (end - start) / 2;

                // Sort first and second halves
                MergeSort(unsortedArray, start, middle);
                MergeSort(unsortedArray, middle + 1, end);

                // Merge the sorted halves
                Merge(unsortedArray, start, middle, end);
            }
        }

        private static void Merge(int[] unsortedArray, int start, int middle, int end)
        {
            int leftIndex = middle - start + 1;
            int rightIndex = end - middle;

            int[] leftArray = new int[leftIndex];
            int[] rightArray = new int[rightIndex];
            int i, j;
            // Initial indexes of first
            // and second subarrays

            Array.Copy(unsortedArray, start, leftArray, 0, leftIndex);
            Array.Copy(unsortedArray, middle + 1, rightArray, 0, rightIndex);

            i = 0;
            j = 0;

            int mergedIndex = start;

            while (i < leftIndex && j < rightIndex)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    unsortedArray[mergedIndex] = leftArray[i];
                    i++;
                }
                else
                {
                    unsortedArray[mergedIndex] = rightArray[j];
                    j++;
                }
                mergedIndex++;
            }   

            while (i < leftIndex)
            {
                unsortedArray[mergedIndex] = leftArray[i];
                i++;
                mergedIndex++;
            }

            while (j < rightIndex)
            {
                unsortedArray[mergedIndex] = rightArray[j];
                j++;
                mergedIndex++;
            }
        }
    }
}
