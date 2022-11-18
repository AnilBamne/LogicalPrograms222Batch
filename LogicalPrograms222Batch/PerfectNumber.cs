using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    class PerfectNumber
    {
        public void CheckPerfect()
        {
            Console.WriteLine("Enter a number to check it is perfect ?");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //computation
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("this is a Perfect Number");
            }
            else
            {
                Console.WriteLine("This is not a Perfect Number");
            }
        }
    }
}
