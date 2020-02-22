using Fizzbuzz.Src.Services;
using System;

namespace Fizzbuzz
{
    class Program
    {
        private static void StartFizzBuzz()
        {
            FizzbuzzExecuter executer = new FizzbuzzExecuter();

            Console.WriteLine("Até quanto você quer executar o Fizz Buzz?");
            string maxValueString = Console.ReadLine();
            int maxValue;
            Int32.TryParse(maxValueString, out maxValue);

            for (int i = 1; i <= maxValue; i++)
            {
                string result = executer.CalculateFizzbuzz(i);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            StartFizzBuzz();
        }
    }
}
