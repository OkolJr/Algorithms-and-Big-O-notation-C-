# Algorithms and Big O notation C#
Cheat sheet for understanding the time and space complexity of algorithms  Big O notation describes the complexity of code using algebraic terms(time and space)  O(n log(n)), also known as loglinear complexity, means that log(n) operations will occur n times. It’s commonly used in recursive sorting algorithms and binary tree sorting algorithms
This is all just an expiriment of sorts to practice my knowledge of algorithms.
<h2 align="center">How do algorithms work:</h1>
<ul>
  <li><h3>Bubble Sort</h3><p><ol type="1"><li>The largest element is placed in its correct position, i.e., the end of the array.</li>
    <li>Place the second largest element at correct position</li>
    <li>Place the remaining two elements at their correct positions.</li></ol></p></li>
  <li><h3>Binary Search</h3><p><ol type="1">
    <li>Divide the search space into two halves by finding the middle index “mid”. </li>
    <li>Compare the middle element of the search space with the key. </li>
    <li>If the key is found at middle element, the process is terminated.</li>
    <li>If the key is not found at middle element, choose which half will be used as the next search space.</li>
    <li>If the key is smaller than the middle element, then the left side is used for next search.</li>
    <li>If the key is larger than the middle element, then the right side is used for next search.</li>
    <li>This process is continued until the key is found or the total search space is exhausted.</li></ol></p></li>
  <li><h3>Insertion Sort</h3><p>Insertion sort compares the current element with the next element and determines whether the current element is greater than the one it was compared to.</p></li>
  <li><h3>Merge Sort</h3><p><ol type="1">
    <li>Divide: Split the array into two halves. Keep dividing each half recursively until each subarray contains only one element.</li>
    <li>Conquer: Sort each of the subarrays. Since each subarray has only one element, they are already sorted.</li>
    <li>Merge: Combine the sorted subarrays to form a single sorted array. This merging process involves comparing the elements of the subarrays and arranging them in order.</li></ol></p></li>
  <li><h3>Selection Sort</h3><p><ol type="1">
    <li>Start with the first element: Assume the first element is the minimum.</li>
    <li>Compare with the rest: Compare this minimum with the second element. If the second element is smaller, it becomes the new minimum. Continue this process for the entire list.</li>
    <li>Swap: After finding the minimum element in the unsorted portion, swap it with the first element of the unsorted portion.</li>
    <li>Repeat: Move to the next element and repeat the process for the remaining unsorted portion of the list.</li>
    <li>Continue until sorted: Repeat these steps until the entire list is sorted.</li></ol></p></li>
  <li><h3>Heap Sort</h3><p>First convert the array into a max heap using heapify, Then one by one delete the root node of the Max-heap and replace it with the last node and heapify. Repeat this process while size of heap is greater than 1.<ol type="1">
    <li>Build a max heap from the given input array.</li>
    <li>Repeat the following steps until the heap contains only one element:<ul>
      <li>Swap the root element of the heap (which is the largest element) with the last element of the heap.</li>
      <li>Remove the last element of the heap (which is now in the correct position).</li></ul></li>
    <li>Heapify the remaining elements of the heap.</li>
    <li>The sorted array is obtained by reversing the order of the elements in the input array.</li></ol></p></li>
</ul>
