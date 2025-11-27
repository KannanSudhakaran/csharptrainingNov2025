using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Domain
{
    class Toddler : Man
    {
        public override void Play()
        {
            Console.WriteLine("Toddler is playing..");
        }
    }
}
