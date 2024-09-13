
namespace Fibonacci
{
    public static class FibonacciRecursiveImplementation
    {
        public static int Fibonacci(int input)
        {
            if (input <= 2)
            {
                return 1;
            }

            return Fibonacci(input - 1) + Fibonacci(input - 2);
        }
    }
}
