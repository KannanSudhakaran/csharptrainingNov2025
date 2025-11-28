using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
    class AccountInsufficientFundsException:Exception
    {
        private Account _account;//has A instance of account

        public AccountInsufficientFundsException(Account account)
        {
            _account = account;
        }

        public override string Message
        {

            get
            {
                return $"Admin:Bank of Germany says {_account.Name} dont have funds";
            }

        }
    }
}
