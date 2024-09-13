# Algorithms-and-Big-O-notation-C#
Cheat sheet for understanding the time and space complexity of algorithms

Big O notation describes the complexity of code using algebraic terms(time and space).
The formula or variable in parenthesis after O means the worst-case scenario of the complexity of an algorithm.
Here are 7 examples of complexity:

O(1), means that the algorithm has constant complexity and in code could be described as the amount of time or memory that does not scale with n. For time complexity, n is not iterated on or recursed.

O(log n), one of the most desirable complexities, means that time increases logarithmically to increase input n. Basically, in computer science, we take log as log2(n).

O(n), linear complexity, means that time or space increases with increase of input. For example

O(n log(n)), also known as loglinear complexity, means that log(n) operations will occur n times. It’s commonly used in recursive sorting algorithms and binary tree sorting algorithms.

O(N^2) – quadratic time complexity. The time required to run the algorithm increases quadratically with the size of the input. For example, if we have an input of elements it will be 25 operations done.

O(N^3) – cubic time complexity. The time required to run the algorithm increases cubically with the size of the input. The same as the previous example. Can be described as a foreach loop with 2 nested foreach loops inside.

O(2^N) - in this case, the input is power for 2. This means, that an increase in input increases time needed for operation exponentially.

O(N!) – worst complexity. This means that the time required to run the algorithm increases factorially with the size of the input. For example, if the input is 5 then the number of operations will be equal to 5 x 4 x 3 x 2 x 1
