using System;
using System.Collections.Generic;

namespace LogicalPrograms222Batch
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logiocal Programs");
            Console.WriteLine("Select the Program to execute\n\n1:Fibonacci Series\n2:Perfect Number\n3:Prime Number\n4:Reverse a number\n5:Coupon Numbers\n6:Simulate Stopwatch Program\n ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.fibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.checkPerfect();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.isPrimeNum();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.revNum();
                    break;
                default:
                    break;
            }
            Console.WriteLine("**************************");

        }
    }
}
