using Fizzbuzz.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzbuzzTest.Services
{
    public class FibonacciServiceTest
    {
        // Calcular sequencia Fibonacci até o número N

        [Test]
        public void CalculateFibonacciSequenceUntil_1_SequenceUntil1()
        {
            FibonacciService fibonacciService = new FibonacciService();
            List<int> actualResult = fibonacciService.CalculateFibonacciSequenceUntil(1);

            List<int> resultExpected = new List<int>() { 0, 1, 1 };

            Assert.AreEqual(resultExpected, actualResult);
        }

        [Test]
        public void CalculateFibonacciSequenceUntil_2_SequenceUntil2()
        {
            FibonacciService fibonacciService = new FibonacciService();
            List<int> actualResult = fibonacciService.CalculateFibonacciSequenceUntil(2);

            List<int> resultExpected = new List<int>() { 0, 1, 1, 2};

            Assert.AreEqual(resultExpected, actualResult);
        }
    }
}
