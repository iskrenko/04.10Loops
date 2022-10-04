using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAc = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                string jury = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                int j = jury.Length;
                pointsAc += j * points / 2;

                if (pointsAc >= 1250.5) 
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pointsAc:f1}!");
                    break;
                }

            }
            if (pointsAc < 1250.5) 
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - pointsAc:f1} more!");
            }
        }
    }
}
