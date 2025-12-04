using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenericsApp.Domain
{
    class OrderItem
    {
        //fields are generated automatically
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quanity { get; set; } 
        public double UnitPrice { get; set; }

        public double TotalCost() { 
          return Quanity* UnitPrice; 
        }

        //callback
        public override int GetHashCode()
        {
            return this.Id;
        }

        //callabck
        public override bool Equals(object? second)
        {
          var secondOrderItem=   second as OrderItem;

            return (secondOrderItem.Id == this.Id
                  && secondOrderItem.Name == this.Name);


            

        }

    }
}
