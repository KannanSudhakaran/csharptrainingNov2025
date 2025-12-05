using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Domain
{

   public delegate void DAccountUpdated(Account acc);
   public class Account
    {
        //fields
        private readonly string _accno; //immutable
        private readonly string _name; //immutable
        private  double _balance;//mutable

        private const int MinBalance = 500;
        //constructor

        //event is an encapsulation of a delegate
        public event DAccountUpdated OnBalanceChanged=null;


        public Account(string accno, string name, double balance)
        {

            _accno = accno;
            _name = name;
            _balance = balance;
        }
        public Account(string accno, string name):this(accno,name,MinBalance)
        {
            
        }

        
        //methods
        public void Deposit(double amount) {

            _balance += amount;//state is changed

            if (OnBalanceChanged != null) {
                OnBalanceChanged(this);
            }

        }

       

        public void Withdraw(double amount) {
            if (_balance - amount > MinBalance)
            {
                _balance = _balance - amount;//state is changed
                if (OnBalanceChanged != null)//if any event hanlder attached
                {
                    OnBalanceChanged(this);
                }

            }
            else
                Console.WriteLine("Error to be thrown");
        }

       

        //properties
        public string Accno { 
          get { return _accno; } //readonly property
        }
        public string Name {
            get {
                return _name;
            }
           
        }

        public double Balance {
            get {
                return _balance;
            }
        }

    }
}
