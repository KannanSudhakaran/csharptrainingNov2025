using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
    class SavingsAccount:Account
    {
        private const int MIN_BALANCE = 1000;
        public SavingsAccount(string accno, string name, double balance) 
            : base(accno, name, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (_balance - amount >= MIN_BALANCE) { 
              _balance -= amount;
            }
            //TODO: custom exception need to thrown
        }
    }
}
