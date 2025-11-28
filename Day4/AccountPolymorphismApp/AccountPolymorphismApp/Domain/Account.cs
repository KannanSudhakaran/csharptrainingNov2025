using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
   abstract class Account
    {
        private readonly string _accountno;
        private readonly string _name;
        protected double _balance;


        public Account(string accno, string name, double balance)
        {
            _accountno = accno;
            _name = name;
            _balance = balance;


        }
        public void Deposit(double amount) {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);


        public string Name { get { return _name; } }
        public string AccountNo { get { return _accountno; } }

        public double Balance { get { return _balance; } }

    }
}
