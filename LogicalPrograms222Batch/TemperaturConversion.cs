using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class TemperaturConversion
    {
        public void ConvertFhrenheitToCelcius()
        {
            //Variables
            double Fahrenheit;
            double Celcius;
            Console.WriteLine("Enter temperature in Fahrenheit");
            Fahrenheit=double.Parse(Console.ReadLine());
            //computation using standars formula
            Celcius = (Fahrenheit-32)*5/9;
            Console.WriteLine("{0} Fahrenheit in Celcius is : {1} ",Fahrenheit,Celcius);
        }
        public void ConvertCelciusToFahrenheit()
        {
            //Variables
            double Fahrenheit;
            double Celcius;
            Console.WriteLine("Enter temperature in Celcius");
            Celcius = double.Parse(Console.ReadLine());
            //computation using standars formula
            Fahrenheit = (Celcius*9/5)+32;
            Console.WriteLine("{0} Celcius in Fahrenheit is : {1} ", Celcius, Fahrenheit);
        }
    }
}
