using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTimers
{
    class Program
    {
        static int globalCounter = 0;

        static void Main(string[] args)
        {
            System.Timers.Timer tmr = new System.Timers.Timer();

           
            tmr.Interval = 200;
            tmr.Start();

            int counter = 0;

         
            tmr.Elapsed += (sender, e) =>
            {
                Console.WriteLine("Timer elapsed... {0}", counter);
                counter++;
            };

            tmr.Elapsed += Tmr_Elapsed;

            Console.ReadLine();
        }

        private static void Tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed 2... {0}", globalCounter);
            globalCounter++;
        }

        private static void Tmr_Disposed(object sender, EventArgs e)
        {
            Console.WriteLine("Timer disposed...");
        }
    }
}
