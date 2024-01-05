using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
    class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime Orderdate { get; set; }
        public int Quantity { get; set; }

        public Order(int id, string Name, DateTime orderdate, int quantity)
        {
            OrderId = id;
            ItemName = Name;
            Orderdate = orderdate;
            Quantity = quantity;

        }
    }

    internal class Prgm3
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order (1,"Watch",DateTime.Parse("02/23/2015"),10),
                new Order (2,"shirt",DateTime.Parse("06/20/2020"),20),
                new Order (3,"pant",DateTime.Parse("07/20/2023"),25),
                new Order (4,"phone",DateTime.Parse("01/22/2024"),3)

            };
            var orderedByDateAndQuantity = orders.OrderByDescending(o => o.Orderdate).ThenByDescending(o => o.Quantity);
            foreach (var order in orderedByDateAndQuantity)
            {
                Console.WriteLine($"Order_Id:{order.OrderId}, Item_Name:{order.ItemName},Order_Date:{order.Orderdate},Quantity:{order.Quantity}");
            }

        }
    }
}


