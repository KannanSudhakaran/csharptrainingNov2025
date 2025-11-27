
using System;

namespace PlayerThisPointerApp.Domain
{
    class Player
    {
        //attributes
        //constructor
        //methods
        //properties

        private readonly string _name;
        private readonly int _age;
        private const int MIN_AGE = 20;

        public Player(string _name, int _age) {

           this._name = _name;
           this._age = _age;

            Console.WriteLine("Player created with 2params");
        }

        public Player(string _name) : this(_name,MIN_AGE)
        {

            Console.WriteLine("player created with 1prams");
        }


        public Player WhoIsElder(Player secondPlayer) {

            if (this._age > secondPlayer._age)
            {
                return this;
            }


            return secondPlayer;
        }

        public string Name
        {
            get { return _name; } 
        }

        public int Age { 
          get  { return _age; }
        }

    }
}
