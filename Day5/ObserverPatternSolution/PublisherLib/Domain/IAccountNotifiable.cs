using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Domain
{
    public interface IAccountNotifiable
    {
        void Notify(Account account);
    }
}
