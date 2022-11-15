using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms222Batch
{
    internal class StopwatchProgram
    {
        public void stopWatch()
        {
            Stopwatch s = new Stopwatch();
            Console.WriteLine("Start the stop watch");
            s.Start();
            Console.WriteLine("Stop the stop watch");
            s.Stop();
            Console.WriteLine("the elapsed time is : {0}  milli seconds ", s.ElapsedMilliseconds);
        }
    }
}
