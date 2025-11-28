using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    interface ICrudable
    {
        //exposes behaviors,so all methods are public

        void Create();
        void Read();
        void Update();
        void Delete();

    }
}
