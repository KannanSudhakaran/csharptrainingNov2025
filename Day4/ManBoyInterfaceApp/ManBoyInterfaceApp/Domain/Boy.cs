using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Domain
{
    class Boy : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying..");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is departing..");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing..");
        }

        public void Wish()
        {
            Console.WriteLine("Boy is wishing hello..");
        }
    }
}
