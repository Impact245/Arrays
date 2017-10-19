using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] j = new String[100];

            for (int i = 0; i < j.Length; i++)
            {
                j[i] = i + ".";
                if (i % 3 == 0 && i % 5 == 0)
                {
                    j[i] = i + ". FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    j[i] = i + ". Fizz";
                }
                else if (i % 5 == 0)
                {
                    j[i] = i + ". Buzz";
                }
                Console.WriteLine(j[i]);
            }
        }
    }
}
