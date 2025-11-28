using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    class InvoiceDb : MyDbEntity, ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Invoice is created");
        }

        public void Delete()
        {
            Console.WriteLine("Invoice is deleted");
        }

        public void Read()
        {
            Console.WriteLine("Invoice is read");
        }

        public void Update()
        {
            Console.WriteLine("Invoice is updated");
        }
    }
}
