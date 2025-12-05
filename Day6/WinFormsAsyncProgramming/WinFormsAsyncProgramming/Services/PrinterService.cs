using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAsyncProgramming.Services
{
    internal class PrinterService
    {
        public void Print() {

            while (true) {

                Debug.WriteLine($"time is : {DateTime.Now.ToString("hh:mm:ss")}");
            
            }
        
        }

        public void Print(int seconds)
        {
            DateTime startTime = DateTime.Now;
            TimeSpan futureTime=  TimeSpan.FromSeconds( seconds );

            while (DateTime.Now-startTime < futureTime)
            {

                Debug.WriteLine($"time is : {DateTime.Now.ToString("hh:mm:ss")}");

            }

        }

        public void PrintViaThread(int seconds) { 
        
            
            Thread worker = new Thread(() => Print(seconds));
            worker.Start();

        
        }
    }
}
