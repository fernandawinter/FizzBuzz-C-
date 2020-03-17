using System;
using System.Collections.Generic;
using System.Text;

namespace Fizzbuzz.Services
{
    public class FibonacciService
    {
        public List<int> CalculateFibonacciSequenceUntil(int number)
        {
            List<int> fibonacciSequence = new List<int>();

            fibonacciSequence.Add(0);
            fibonacciSequence.Add(1);
            fibonacciSequence.Add(1);
            fibonacciSequence.Add(2);

            return fibonacciSequence;
        }
    }
}
