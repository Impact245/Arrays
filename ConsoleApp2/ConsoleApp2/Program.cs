using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = new int[50];
            Random j = new Random();

            for (int i = 0; i < k.Length; i++)
            {
                k[i] = j.Next(1, 50);
            }

            Array.Sort(k);

            for (int i = 0; i < k.Length; i++)
            {
                Console.Write(k[i] + ",");
                if(i % 10 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Min: " + k[0]);
            Console.Write("Max: " + k[k.Length-1]);
        }
    }
}
