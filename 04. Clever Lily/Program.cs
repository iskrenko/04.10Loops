using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double wmPrice = double.Parse(Console.ReadLine());
            int tPrice = int.Parse(Console.ReadLine());

            int savings = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    
                    savings +=i*5 -1 ;
                }
                if (i % 2 == 1)
                    savings += tPrice;
            }
            if (savings >= wmPrice)
            {
                Console.WriteLine($"Yes! {savings - wmPrice:f2}");
            }
            else
                Console.WriteLine($"No! {wmPrice - savings:f2}");
        }
    }
}
