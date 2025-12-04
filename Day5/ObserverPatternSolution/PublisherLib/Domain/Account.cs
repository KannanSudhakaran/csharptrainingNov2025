using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Domain
{
   public class Account
    {
        //fields
        private readonly string _accno; //immutable
        private readonly string _name; //immutable
        private  double _balance;//mutable

        private const int MinBalance = 500;
        //constructor

        private List<IAccountNotifiable> _observers;

        
        public Account(string accno, string name, double balance)
        {

            _accno = accno;
            _name = name;
            _balance = balance;
            _observers = new List<IAccountNotifiable>();
        }
        public Account(string accno, string name):this(accno,name,MinBalance)
        {
            
        }

        
        //methods
        public void Deposit(double amount) {

            _balance += amount;//state is changed

            NotifyAllObservers();

        }

       

        public void Withdraw(double amount) {
            if (_balance - amount > MinBalance)
            {
                _balance = _balance - amount;//state is changed
                NotifyAllObservers();

            }
            else
                Console.WriteLine("Error to be thrown");
        }

        public void RegisterObserver(IAccountNotifiable observer)
        {

            _observers.Add(observer);

        }
        private void NotifyAllObservers()
        {
            foreach (IAccountNotifiable observer in _observers)
            {
                observer.Notify(this);
            }
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
