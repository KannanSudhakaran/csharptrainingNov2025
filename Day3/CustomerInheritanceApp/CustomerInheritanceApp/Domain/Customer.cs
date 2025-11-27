using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInheritanceApp.Domain
{
    class Customer // ISA Object
    {
        private readonly string _id;
        private readonly string _name;
        private readonly string _country;

        public Customer(string id, string name, string country)
        {
            _id = id;
            _name = name;
            _country = country;

            Console.WriteLine("customer created");
        }

        public Customer(string myid, string myname)
            :this(myid,myname,"Germany")
        { 
        
        }

        //methods

        public override string ToString()//20 lines
        {
            return $"id={_id},name : {_name},country:{_country},parent:{base.ToString()}";
        }

        public override bool Equals(object? second)
        {
            //casting
              Customer secondCustomer= second as Customer;

            return (this._id == secondCustomer._id);

        }

        //properties
        public string Id { 
          get { return _id; }
        }

        public string Country
        {
            get { return _country; }
        }

        public string Name
        {
            get { return _name; }
        }



    }
}
