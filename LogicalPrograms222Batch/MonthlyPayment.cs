using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class MonthlyPaymentDemo
    {
        public void Monthlypayment()
        {
            //Variables
            double principal, years, rateOfInterest, payment;
            Console.WriteLine("Enter the principal amount");
            principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time in years");
            years = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            rateOfInterest = double.Parse(Console.ReadLine());
            double n = years * 12;
            double r = rateOfInterest / (12 * 100);
            payment = (principal * r) / (1 - Math.Pow((1+r),-n));
            Console.WriteLine("The monthly payment is :"+payment);
        }
        
        
    }
}
