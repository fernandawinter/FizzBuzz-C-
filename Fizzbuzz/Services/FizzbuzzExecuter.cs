using System;
using System.Collections.Generic;
using System.Text;

namespace Fizzbuzz.Src.Services
{
    public class FizzbuzzExecuter
    {
        public string CalculateFizzbuzz(int i)
        {
            if (i == 0)
            {
                return "0";
            }

            if (i % 3 == 0 && i % 5 == 0)
            {
                return "Fizzbuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}
