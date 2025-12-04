using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPatternApp.Services
{
    internal class DataService
    {
        private static DataService _bucket = null;
        private DataService()
        {
            Console.WriteLine($"DataService created  {this.GetHashCode()} ");
        }

        public static DataService GetInstance() {//instance method
            if (_bucket == null)
            {

                _bucket= new DataService();
            }

            return _bucket;
        }

        public int GetData() {

            Console.WriteLine("data fetching through "+this.GetHashCode());
            Random random = new Random();
            int value = random.Next(100);
            return value;
        
        }
    }
}
