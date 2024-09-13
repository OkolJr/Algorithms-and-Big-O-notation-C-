using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinarySearchImplementation
    {
        public static int BinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                // We look for midpoint of the array
                int mid = low + (high - low) / 2;

                // Check if value on midpoint index is searched value
                if (arr[mid] == x)
                    return mid;
                // Check if value on midpoint index is smaller than searched value
                if (arr[mid] < x)
                    low = mid + 1;
                // If value on midpoint index is bigger than searched value then new highest index has to be changed
                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}
