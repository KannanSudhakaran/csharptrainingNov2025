using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    class  CustomerDb : MyDbEntity, ICrudable,IEnumerable
    {
        //public abstract void Create();
        //public abstract void Delete();
        //public abstract void Read();
        //public abstract void Update();

        public void Create()
        {
            Console.WriteLine("Customer is Created");
        }

        public void Delete()
        {
            Console.WriteLine("Customer is Deleted");
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            Console.WriteLine("Customer is read");
        }

        public void Update()
        {
            Console.WriteLine("Customer is updated");
        }
    }
}
