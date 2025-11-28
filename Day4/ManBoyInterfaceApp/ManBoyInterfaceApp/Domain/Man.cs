using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Domain
{
    class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man departs goodbye");
        }

        public void Wish()
        {
            Console.WriteLine("Man wishes hello");
        }
    }
}
