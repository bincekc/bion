using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
   
    internal class Prgm6
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>()
            {

                new Order (1,"Watch",DateTime.Parse("02/23/2015"),10),
                new Order (2,"shirt",DateTime.Parse("06/20/2020"),20),
                new Order (3,"pant",DateTime.Parse("07/20/2023"),25),
                new Order (4,"phone",DateTime.Parse("01/22/2024"),7),
                 new Order (5,"Headset",DateTime.Parse("05/02/2023"),5)
            };
            List<Item> items = new List<Item>()
                {
                    new Item("Paste",30),
                    new Item("Soap",40),
                    new Item("Shoes",300)
                };
            var result = from s in orders
                         join e in items
                         on s.ItemName equals e.ItemName
                         select new { id = s.OrderId, name = s.ItemName, dt = s.Orderdate, price = (s.Quantity * e.Price) };
            foreach (var item in result)
            {
                Console.WriteLine($"ID:{item.id} Name :{item.name} Orderdate :{item.dt} totalPrice:{item.price}");
            }
            var orderedByMonth = orders.OrderByDescending(o => o.Orderdate).GroupBy(o => o.Orderdate.Month);


            foreach (var item in orderedByMonth)
            {
                Console.WriteLine($"Month:{item.Key}");

                foreach (var ord in item)
                {
                    Console.WriteLine($"Orderid:{ord.OrderId}, item_name:{ord.ItemName},Orderdate:{ord.Orderdate},Quantity:{ord.Quantity}");
                }


            }
        }
    }


}
