using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean t = true;

            int[] j = new int[50];
            Random k = new Random();

            for (int i = 0; i < j.Length; i++)
            {
                j[i] = k.Next(1, 50);
            }

            for (int l = 0; l < j.Length-1; l++)
            {
                t = true;
                for (int h = l+1; h < j.Length; h++)
                {
                    if (j[l] == j[h])
                    {
                        t = false;
                    }
                }

                for (int g = l-1; g >= 0; g--)
                {
                    if (j[l] == j[g])
                    {
                        t = false;
                    }
                }
                if (t)
                {
                    Console.WriteLine(j[l]);
                }
            }



        }
    }
}
