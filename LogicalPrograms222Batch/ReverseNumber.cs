using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class ReverseNumber
    {
        public  void RevNum()
        {
            //variables
            int rev = 0;
            Console.WriteLine("Enter a number to be reversed");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Before : " + num);
            //computation
            while (num != 0)
            {
                int reminder = num % 10;
                rev = rev * 10 + reminder;
                num = num / 10;
            }
            Console.WriteLine("after : " + rev);
        }
    }
}
