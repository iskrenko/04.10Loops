using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                group = int.Parse(Console.ReadLine());
                total += group;
                if (group <= 5)
                {
                    p1 += group;
                }
                else if (group <= 12)
                {
                    p2 += group;
                }
                else if (group <= 25)
                {
                    p3 += group;
                }
                else if (group <= 40)

                {
                    p4 += group;
                }
                else
                    p5 += group;
            }
            Console.WriteLine($"{p1 / total * 100:f2}%");
            Console.WriteLine($"{p2 / total * 100:f2}%");
            Console.WriteLine($"{p3 / total * 100:f2}%");
            Console.WriteLine($"{p4 / total * 100:f2}%");
            Console.WriteLine($"{p5 / total * 100:f2}%");
        }
    }
}
