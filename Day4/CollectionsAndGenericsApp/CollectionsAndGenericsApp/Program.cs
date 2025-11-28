
using CollectionsAndGenericsApp.Domain;
using System.Collections;

namespace CollectionsAndGenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //CaseStudy1();

            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            //generics collections are type safe

            OrderItem item1 = new OrderItem
            {
                UnitPrice = 5,
                Name = "Milk",
                Quanity = 2,
                Id = 1
            };

            OrderItem item2 = new OrderItem
            {
                Id = 2,
                Name = "Biscuits",
                Quanity = 10,
                UnitPrice = 1

            };

            OrderItem item3 = new OrderItem
            {
                Id = 3,
                Name = "Butter",
                Quanity = 10,
                UnitPrice = 2
            };

            List<OrderItem> orderBasket = new List<OrderItem>();
            orderBasket.Add(item1);
            orderBasket.Add(item2);
            orderBasket.Add(item3);
           // orderBasket.Add("Daniel");//compile time error
            //orderBasket.Add(100);//compile time error

            double checkoutPrice = 0;
            foreach (OrderItem item in orderBasket)
            {

                Console.WriteLine(item.Name);
                Console.WriteLine(item.UnitPrice + " " + item.Quanity);
                checkoutPrice = checkoutPrice + item.TotalCost();
            }

            Console.WriteLine("Checkout price at counter :" + checkoutPrice);

        }

        private static void CaseStudy1()
        {
            //collections are not type safe

            var item1 = new OrderItem {
             UnitPrice=5,
             Name="Milk",
             Quanity=2,
             Id=1
            };

            var item2 = new OrderItem {
             Id=2,
             Name="Biscuits",
             Quanity=10,
             UnitPrice=1

            };

            var item3 = new OrderItem { 
             Id=3,
             Name= "Butter",
             Quanity=10,
             UnitPrice=2
            };

            ArrayList orderBasket = new ArrayList();
            orderBasket.Add(item1);
            orderBasket.Add(item2);
            orderBasket.Add(item3);
           // orderBasket.Add("Daniel");
           orderBasket.Add(100);

            double checkoutPrice = 0;
            foreach (object box in orderBasket) {

               OrderItem item= (OrderItem) box;

                Console.WriteLine(item.Name);
                Console.WriteLine(item.UnitPrice+ " "+ item.Quanity);
                checkoutPrice =checkoutPrice+ item.TotalCost();


            }

            Console.WriteLine("Checkout price at counter :"+checkoutPrice);
            
            
        }
    }
}
