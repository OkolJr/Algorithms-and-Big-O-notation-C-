using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciIterativeImplementation
    {
        public static int Fibonacci(int input)
        {
            int a = 0, b = 1, temp;

            for (int i = 0; i < input; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
