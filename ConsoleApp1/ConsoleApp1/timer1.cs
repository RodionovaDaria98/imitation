using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace ConsoleApp1

{
    public class timer1
    {
        

        private static System.Timers.Timer aTimer;

        public static void main1()
        {
            SetTimer();


            Console.WriteLine("Object in state at {0:HH:mm:ss}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }

        private static void SetTimer()
        {
             Random _random = new Random();
            aTimer = new System.Timers.Timer(_random.Next(100, 100000));
            // Hook up the Elapsed event for the timer. 
            ;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

      private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Object in state at  {0:HH:mm:ss}",
                e.SignalTime);
        }
    }


}