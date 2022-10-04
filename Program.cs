using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int num;
            int sum = 0;

            for (int i = 1; i <=n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum) 
                {
                maxNum = num;
                }
               

            }
            if ((sum - maxNum) == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((sum - maxNum) - maxNum)}");
            }
        }
    }
}
