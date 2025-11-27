using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithInheritanceApp.Domain.CaseStudy2
{
    class ParentTwo
    {
        private readonly int _age;
        public ParentTwo(int age) { 
           _age = age;
        
        }

        public int Age { get { return _age; } }
    }
}
