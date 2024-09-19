<h1>Sorting Algorithms</h1>
<h3>What is Sorting?</h3>
Sorting refers to rearrangement of a given array or list of elements according to a comparison operator on the elements. The comparison operator is used to decide the new order of elements in the respective data structure. Sorting means reordering of all the elements either in ascending or in descending order.
<h3>Sorting Terminology:</h3><ul>
<li>In-place Sorting: An in-place sorting algorithm uses constant space for producing the output (modifies the given array only) or copying elements to a temporary storage. Examples: Selection Sort, Bubble Sort Insertion Sort and Heap Sort.</li>
<li>Internal Sorting: Internal Sorting is when all the data is placed in the main memory or internal memory. In internal sorting, the problem cannot take input beyond its size. Example: heap sort, bubble sort, selection sort, quick sort, shell sort, insertion sort.</li>
<li>External Sorting : External Sorting is when all the data that needs to be sorted cannot be placed in memory at a time, the sorting is called external sorting. External Sorting is used for the massive amount of data. Examples: Merge sort, Tag sort, Polyphase sort, Four tape sort, External radix sort, etc.</li>
<li>Stable sorting: When two same items appear in the same order in sorted data as in the original array called stable sort. Examples: Merge Sort, Insertion Sort, Bubble Sort.</li>
<li>Unstable sorting: When two same data appear in the different order in sorted data it is called unstable sort. Examples: Selection Sort, Quick Sort, Heap Sort, Shell Sort.</li></ul>
<h3>Characteristics of Sorting Algorithms:</h3><ul>
<li>Time Complexity: Time complexity, a measure of how long it takes to run an algorithm, is used to categorize sorting algorithms. The worst-case, average-case, and best-case performance of a sorting algorithm can be used to quantify the time complexity of the process.</li>
<li>Auxiliary Space : This is the amount of extra space (apart from input array) needed to sort. For example, Merge Sort requires O(n) and Insertion Sort O(1) auxiliary space</li>
<li>Stability: A sorting algorithm is said to be stable if the relative order of equal elements is preserved after sorting. This is important in certain applications where the original order of equal elements must be maintained.</li>
<li>In-Place Sorting: An in-place sorting algorithm is one that does not require additional memory to sort the data. This is important when the available memory is limited or when the data cannot be moved.</li>
<li>Adaptivity: An adaptive sorting algorithm is one that takes advantage of pre-existing order in the data to improve performance. For example insertion sort takes time proportional to number of inversions in the input array.</li></ul>
<h2>Different types of sorting algorithms:</h1>
<h3>Bubble Sort</h3><p><ol type="1"><li>The largest element is placed in its correct position, i.e., the end of the array.</li>
<li>Place the second largest element at correct position</li>
<li>Place the remaining two elements at their correct positions.</li></ol></p>
<h3>Bucket Sort</h3><p>Bucket sort is a sorting technique that involves dividing elements into various groups, or buckets. These buckets are formed by uniformly distributing the elements. Once the elements are divided into buckets, they can be sorted using any other sorting algorithm. Finally, the sorted elements are gathered together in an ordered fashion.</p>
<h3>Binary Search</h3><p><ol type="1">
<li>Divide the search space into two halves by finding the middle index “mid”. </li>
<li>Compare the middle element of the search space with the key. </li>
<li>If the key is found at middle element, the process is terminated.</li>
<li>If the key is not found at middle element, choose which half will be used as the next search space.</li>
<li>If the key is smaller than the middle element, then the left side is used for next search.</li>
<li>If the key is larger than the middle element, then the right side is used for next search.</li>
<li>This process is continued until the key is found or the total search space is exhausted.</li></ol></p></li>
<h3>Insertion Sort</h3><p>Insertion sort compares the current element with the next element and determines whether the current element is greater than the one it was compared to.</p>
<h3>Counting Sort</h3><p>Counting Sort is a non-comparison-based sorting algorithm. It is particularly efficient when the range of input values is small compared to the number of elements to be sorted. The basic idea behind Counting Sort is to count the frequency of each distinct element in the input array and use that information to place the elements in their correct sorted positions.</p>
<h3>Radix Sort</h3><p>Radix Sort is a linear sorting algorithm that sorts elements by processing them digit by digit. It is an efficient sorting algorithm for integers or strings with fixed-size keys. </p>
<h3>Shell Sort</h3><p>Shell sort is mainly a variation of Insertion Sort. In insertion sort, we move elements only one position ahead. When an element has to be moved far ahead, many movements are involved. The idea of ShellSort is to allow the exchange of far items. In Shell sort, we make the array h-sorted for a large value of h. We keep reducing the value of h until it becomes 1. An array is said to be h-sorted if all sublists of every h<sup>th</sup> element are sorted.</p>
<h3>Quick Sort</h3><p>QuickSort is a sorting algorithm based on the Divide and Conquer that picks an element as a pivot and partitions the given array around the picked pivot by placing the pivot in its correct position in the sorted array.</p>
<h3>Merge Sort</h3><p><ol type="1">
<li>Divide: Split the array into two halves. Keep dividing each half recursively until each subarray contains only one element.</li>
<li>Conquer: Sort each of the subarrays. Since each subarray has only one element, they are already sorted.</li>
<li>Merge: Combine the sorted subarrays to form a single sorted array. This merging process involves comparing the elements of the subarrays and arranging them in order.</li></ol></p></li>
<h3>Selection Sort</h3><p><ol type="1">
<li>Start with the first element: Assume the first element is the minimum.</li>
<li>Compare with the rest: Compare this minimum with the second element. If the second element is smaller, it becomes the new minimum. Continue this process for the entire list.</li>
<li>Swap: After finding the minimum element in the unsorted portion, swap it with the first element of the unsorted portion.</li>
<li>Repeat: Move to the next element and repeat the process for the remaining unsorted portion of the list.</li>
<li>Continue until sorted: Repeat these steps until the entire list is sorted.</li></ol></p>
<h3>Heap Sort</h3><p>First convert the array into a max heap using heapify, Then one by one delete the root node of the Max-heap and replace it with the last node and heapify. Repeat this process while size of heap is greater than 1.<ol type="1">
<li>Build a max heap from the given input array.</li>
<li>Repeat the following steps until the heap contains only one element:<ul>
<li>Swap the root element of the heap (which is the largest element) with the last element of the heap.</li>
<li>Remove the last element of the heap (which is now in the correct position).</li></ul></li>
<li>Heapify the remaining elements of the heap.</li>
<li>The sorted array is obtained by reversing the order of the elements in the input array.</li></ol></p></li>