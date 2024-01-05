using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{

    class Item
    {
        public string ItemName { get; set; }
        public int Price { get; set; }

        public Item(string itemname, int p)
        {
            ItemName = itemname;
            Price = p;
        }
    }
    class OrderDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
    }
    internal class Prgm5
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order (1,"Watch",DateTime.Parse("02/23/2015"),10),
                new Order (2,"shirt",DateTime.Parse("06/20/2020"),20),
                new Order (3,"pant",DateTime.Parse("07/20/2023"),25),
                new Order (4,"phone",DateTime.Parse("01/22/2024"),3),
               

            };

            List<Item> items = new List<Item>()
            {
                new Item("watch",599),
                new Item("phone",15000),
                new Item("pant",599)


            };
            List<OrderDetails> result = (from s in orders
                                         join e in items
                                         on s.ItemName equals e.ItemName
                                         select new OrderDetails
                                         {
                                             Id = s.OrderId,
                                             Name = s.ItemName,
                                             Date = s.Orderdate,
                                             TotalPrice = (s.Quantity * e.Price)
                                         }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"ID:{item.Id} Name :{item.Name} Orderdate :{item.Date} totalPrice:{item.TotalPrice}");
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

