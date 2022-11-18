using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class PrimeNumber
    {
        public void IsPrimeNum()
        {
            //variables
            int nunber, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            nunber = int.Parse(Console.ReadLine());
            //computatin
            for (int i = 2; i <= nunber/2; i++)
            {
                if (nunber % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }
    }
}
