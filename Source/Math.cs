using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        int limite = 350;
        public List<int> Fibonacci()
        {
            List<int> fibonacciSequence = new List<int>();

            for (int initial = 0, next = 1, fibonacci = 0; fibonacci <= limite; initial = next, next = fibonacci, fibonacci = initial + next)
            {
                fibonacciSequence.Add(fibonacci);
            }

            return fibonacciSequence;
        }

        public bool IsFibonacci(int numberToTest)
        {
            var fibonacci = Fibonacci();
            return fibonacci.Contains(numberToTest) ? true : false;
        }
    }
}
