
using CollectionsAndGenericsApp.Domain;
using System.Collections;

namespace CollectionsAndGenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //CaseStudy1();

            // CaseStudy2();

            //CaseStudy3();

            //CaseStudy4();

            CaseStudy5();
        }

        private static void CaseStudy5()
        {

            var companyHeadCountMap= new Dictionary<string,int>();
            // companyHeadCountMap.Add("Microsoft", 10000);
            // companyHeadCountMap.Add("Microsoft", 10000);

            companyHeadCountMap["Microsoft"] = 10000;
            companyHeadCountMap["Microsoft"] = 20000;
            companyHeadCountMap["Google"] = 5000;
            companyHeadCountMap["OpenAi"] = 1000;


            Console.WriteLine(companyHeadCountMap.Count);

            foreach (KeyValuePair<string,int> row in companyHeadCountMap)
            {
                Console.WriteLine($" {row.Key} = {row.Value}");
            }

            int[] numbers=  { 10,10,20,20,10,10,20,30};
            //display occurance of 10->2
            // 20 -->3

            var map = new Dictionary<int,int>();
            foreach (var num in numbers) {

                if (map.ContainsKey(num))
                {
                    map[num] += 1;
                }
                else
                    map[num] = 1;

            }

            foreach (var row in map)
            {
                Console.WriteLine($" {row.Key}= {row.Value}");
            }


        }

        private static void CaseStudy4()
        {

            var setOfUniqueOrderItems = new HashSet<OrderItem>();

            var orderItem1 = new OrderItem
            {
                UnitPrice = 5,
                Name = "Milk",
                Quanity = 2,
                Id = 1
            };

            var orderItem2 = new OrderItem
            {
                Id = 2,
                Name = "Biscuits",
                Quanity = 10,
                UnitPrice = 1

            };

            var orderItem3 = new OrderItem
            {
                Id = 2,
                Name = "Biscuits",
                Quanity = 10,
                UnitPrice = 1

            };

            //Console.WriteLine(orderItem1.GetHashCode());
            //Console.WriteLine(orderItem2.GetHashCode());
            //Console.WriteLine(orderItem3.GetHashCode());

            setOfUniqueOrderItems.Add(orderItem1);
            setOfUniqueOrderItems.Add(orderItem2);
            setOfUniqueOrderItems.Add(orderItem3);

            Console.WriteLine($"{orderItem2.GetHashCode()==orderItem3.GetHashCode()}");
            //Console.WriteLine(orderItem3==orderItem2);
            Console.WriteLine($"{orderItem2.Equals(orderItem3)}");

            Console.WriteLine(setOfUniqueOrderItems.Count);
          


        }

        private static void CaseStudy3()
        {

            var setOfUniqueNames = new HashSet<string>();
            setOfUniqueNames.Add("Daniel");
            setOfUniqueNames.Add("Elena");
            setOfUniqueNames.Add("Alexander");
            setOfUniqueNames.Add("Daniel");

            Console.WriteLine(setOfUniqueNames.Count);

            foreach (var name in setOfUniqueNames)
            {
                Console.WriteLine(name);
            }

        }

        private static void CaseStudy2()
        {
            //generics collections are type safe
          
            
            var orderItem1 = new OrderItem
            {
                UnitPrice = 5,
                Name = "Milk",
                Quanity = 2,
                Id = 1
            };

            var orderItem2 = new OrderItem
            {
                Id = 2,
                Name = "Biscuits",
                Quanity = 10,
                UnitPrice = 1

            };

            var orderItem3 = new OrderItem
            {
                Id = 3,
                Name = "Butter",
                Quanity = 10,
                UnitPrice = 2
            };

            List<OrderItem> orderBasket = new List<OrderItem>();
            orderBasket.Add(orderItem1);
            orderBasket.Add(orderItem2);
            orderBasket.Add(orderItem3);
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
