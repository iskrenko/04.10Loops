﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string tab = Console.ReadLine();
                if (tab == "Facebook")
                {
                    salary -= 150;
                }
                else if (tab == "Instagram")
                {
                    salary -= 100;
                }
                else if (tab == "Reddit")
                {
                    salary -= 50;
                }
                if (salary == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
                   
                


            }
            
            
            if (salary>0)
                Console.WriteLine(salary);
            

        }   
    }
}
