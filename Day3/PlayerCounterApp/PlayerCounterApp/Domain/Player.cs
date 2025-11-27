using System;

namespace PlayerCounterApp.Domain
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


        //static field,expose through static Property or method
        private static int _counter = 0;//need to load it from a file

        //static constructor or static block
        static Player() {

            _counter = 100;
            Console.WriteLine("called only once in entire project");

        
        }
        public Player(string _name, int _age) {

           
           this._name = _name;
           this._age = _age;

            _counter += 1;

            Console.WriteLine("Player created with 2params");
        }

        public Player(string _name) : this(_name,MIN_AGE)
        {

           // Console.WriteLine("player created with 1prams");
        }


        public Player WhoIsElder(Player secondPlayer) {

            if (_age > secondPlayer._age)
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

        public int Counter { //instance property or method
           get {
                
                return _counter; }
        
        }


        public static int HeadCounter { //static property or method

            get {
                return _counter;
            }
        
        }

    }
}
