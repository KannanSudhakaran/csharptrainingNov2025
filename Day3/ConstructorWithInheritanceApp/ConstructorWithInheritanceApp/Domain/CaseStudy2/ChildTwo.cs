using ConstructorWithInheritanceApp.Domain.CaseStudy1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithInheritanceApp.Domain.CaseStudy2
{
    class ChildTwo : ParentTwo
    {
        public ChildTwo() : base(20) { 
        
        
        }

        public ChildTwo(int myage) : base(myage) { 
        
        
        }

       
    }
}
