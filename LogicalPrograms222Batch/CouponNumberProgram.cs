using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class CouponNumberProgram
    {
        public void Coupon()
        {
            //variable
            int count = 0;
            //taking user input 
            Console.WriteLine("Enter number of coupons");
            int Number = int.Parse(Console.ReadLine());
            //defining integer array to store distinct coupon numbers
            int[] CouponNumbers = new int[Number];
            Random random = new Random();
            //computation
            for (int i = 0; i < Number; i++)
            {
                int newNum= random.Next(1,25);
                count++;
                if (CouponNumbers.Contains(newNum))
                {
                    //not a distinct number
                }
                else
                {
                    CouponNumbers[i] = newNum;
                }
                count++;
            }
            Console.WriteLine("no of random numbers generated to get "+ Number+" distinct coupon numbers : "+count);
            Console.WriteLine("the coupon numbers are :");
            foreach(int i in CouponNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
