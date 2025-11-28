using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
    class CurrentAccount : Account
    {
        private const int OVER_DRAFT = -10000;
        public CurrentAccount(string accno, string name, double balance) 
            : base(accno, name, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (_balance - amount >= OVER_DRAFT) { 
            
            _balance = _balance - amount;
            }
            //TODO:Custom exception to be thrown
        }
    }
}
