using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1;
            
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <=n ; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += num1;
                }
                else 
                {
                    sum2 += num1;
                }

            }
             
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}