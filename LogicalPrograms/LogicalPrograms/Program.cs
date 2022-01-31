﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1. to print Fabonacci Series \nEnter 2. to print Perfect Number \n" +
                "Enter 3.to print Prime Number \nEnter 4. to print Reverse Number \n");

            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        FibonacciSeries fs = new FibonacciSeries();
                        fs.Series();
                        break;

                    case 2:
                        PerfectNumber number = new PerfectNumber();
                        number.Perfect();
                        break;

                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.Prime();
                        break;

                    case 4:
                        ReverseNumber rev=new ReverseNumber();
                        rev.Reverse();
                        break;








                }
            }

        }
    }
}
