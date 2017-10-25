using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;

            int[] j = new int[50];
            Random k = new Random();

            for (int i = 0; i < j.Length; i++)
            {
                j[i] = k.Next(1, 50);
            }

            for (int l = 0; l < j.Length - 1; l++)
            {
                for (int h = l + 1; h < j.Length; h++)
                {
                    if (j[l] == j[h])
                    {
                        j[h] = -1;
                    }
                }
            }

            for (int y = 0; y < j.Length; y++)
            {
                if (j[y] != -1)
                {
                    t++;
                }
            }

            Console.WriteLine("Length is now " + t);
            



        }
    }
}
