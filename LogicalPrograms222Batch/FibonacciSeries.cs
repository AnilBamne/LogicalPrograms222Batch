using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            //Variable declartion
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            //Taking user input
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            //computation
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.WriteLine(firstNumber );
                Console.WriteLine( SecondNumber);
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i <= numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.WriteLine(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
        }
    }
}
