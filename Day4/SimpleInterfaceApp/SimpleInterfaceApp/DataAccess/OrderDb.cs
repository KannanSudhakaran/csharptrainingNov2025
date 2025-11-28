using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    class  OrderDb : MyDbEntity, ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order created");
        }

        public void Delete()
        {
            Console.WriteLine("Order deleted");
        }

        public void Read()
        {
            Console.WriteLine("Order read");
        }

        public void Update()
        {
            Console.WriteLine("Order updated");
        }
    }
}
