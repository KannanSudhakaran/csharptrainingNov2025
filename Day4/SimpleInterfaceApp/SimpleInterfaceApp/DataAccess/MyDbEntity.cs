using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    class MyDbEntity
    {
        private int _id;

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }
    }
}
