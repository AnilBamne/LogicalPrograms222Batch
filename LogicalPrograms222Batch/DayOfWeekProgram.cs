using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class DayOfWeekProgram
    {
        public void DayOfWeek()
        {
            //Variables
            int d, m, y;        //d=day,m=month,y=year
            Console.WriteLine("Enter the date in dd/mm/yyyy format only");
            d=int.Parse(Console.ReadLine());
            m=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());

            //computation
            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0/ 4)-( y0 / 100 )+(y0 / 400);
            int m0 = m + (12*((14-m)/12))-2;
            int d0 = (d+x +((31*m0)/12)) % 7;
            Console.WriteLine(m0);
            switch (d0)
            {
                case 1:
                    Console.WriteLine("this is Monday");
                    break;
                case 2:
                    Console.WriteLine("this is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("this is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("this is Thursday");
                    break;
                case 5:
                    Console.WriteLine("this is Friday");
                    break;
                case 6:
                    Console.WriteLine("this is Saturday");
                    break;
                case 7:
                    Console.WriteLine("this is Sunday");
                    break;
               default:
                    break;
            }
            switch (m)
            {
                case 1:
                    Console.WriteLine("of January");
                    break;
                case 2:
                    Console.WriteLine("of February");
                    break;
                case 3:
                    Console.WriteLine("of March");
                    break;
                case 4:
                    Console.WriteLine("of April");
                    break;
                case 5:
                    Console.WriteLine("of May");
                    break;
                case 6:
                    Console.WriteLine("of June");
                    break;
                case 7:
                    Console.WriteLine("of July");
                    break;
                case 8:
                    Console.WriteLine("of August");
                    break;
                case 9:
                    Console.WriteLine("of September");
                    break;
                case 10:
                    Console.WriteLine("of October");
                    break;
                case 11:
                    Console.WriteLine("of November");
                    break;
                case 12:
                    Console.WriteLine("of December");
                    break;
                default:
                    break;
            }
        }
    }
}
