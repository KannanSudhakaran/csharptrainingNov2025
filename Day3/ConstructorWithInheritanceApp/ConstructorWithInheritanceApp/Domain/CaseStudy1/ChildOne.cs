using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithInheritanceApp.Domain.CaseStudy1
{
    class ChildOne : ParentOne
    {

        //automatically or implicitly
        public ChildOne() :base(){
            
            Console.WriteLine("Child created");
        
        }
    }
}
