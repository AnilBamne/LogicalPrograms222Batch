using System;
using System.Collections.Generic;

namespace LogicalPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logiocal Programs");
            Console.WriteLine("Select the Program to execute\n\n1:Fibonacci Series\n2:Perfect Number\n3:Prime Number\n4:Reverse a number\n5:Simulate Stopwatch Program\n6:Coupon Numbers\n-------\nNUnit Programs\n--------\n7:Day Of Week Program\n8:TemperaturConversion\n9:Monthly Payment ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.Fibonacci();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.CheckPerfect();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.IsPrimeNum();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.RevNum();
                    break;
                case 5:
                    StopwatchProgram stopwatch = new StopwatchProgram();
                    stopwatch.StopWatch();
                    break;
                case 6:
                    CouponNumberProgram couponNumberProgram = new CouponNumberProgram();
                    couponNumberProgram.Coupon();
                    break;
                case 7:
                    DayOfWeekProgram dayOfWeek = new DayOfWeekProgram();
                    dayOfWeek.DayOfWeek();
                    break;
                case 8:
                    TemperaturConversion temperaturConversion = new TemperaturConversion();
                    temperaturConversion.ConvertFhrenheitToCelcius();
                    temperaturConversion.ConvertCelciusToFahrenheit();
                    break;
                case 9:
                    MonthlyPaymentDemo monthlyPayment = new MonthlyPaymentDemo();
                    monthlyPayment.Monthlypayment();
                    break;
                case 10:
                    break;

                default:
                    break;
            }

        }
    }
}
