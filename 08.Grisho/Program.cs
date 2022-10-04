using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Grisho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int points = int.Parse(Console.ReadLine());
            double p1 = 0;
            int turP = 0;

            for (int i = 0; i < n; i++)
            {
                string pos = Console.ReadLine().ToUpper();

                if (pos=="W")
                {
                    points += 2000;
                    p1++;
                    turP +=2000 ;
                }
                else if (pos=="F")
                {
                    points += 1200;
                    turP += 1200;
                }
                else if (pos=="SF")
                {
                    points += 720;
                    turP += 720;
                }

                
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {turP/n}");
            Console.WriteLine($"{p1/n*100:f2}%");
            

        }
    }
}
