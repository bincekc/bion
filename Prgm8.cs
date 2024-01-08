using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace LinqAssignment
    {
        class Orders5
        {
            public int OrderId { get; set; }
            public string ItemName { get; set; }
            public DateTime OrderDate { get; set; }
            public int Quantity { get; set; }
        }

        class Item5
        {
            public string ItemName { get; set; }
            public double Price { get; set; }
        }

        internal class Prgm8
        {
            public static void Main()
            {
                List<Order> orders = new List<Order>
            {
                new Order { OrderId = 111, ItemName = "bat", OrderDate = new DateTime(2024, 1, 5), Quantity = 2 },
                new Order { OrderId = 2222, ItemName = "ball", OrderDate = new DateTime(2024, 1, 8), Quantity = 6 },
                new Orders5 { OrderId = 3122, ItemName = "stick", OrderDate = new DateTime(2024, 2, 12), Quantity = 5 },
            };

                List<Item5> items = new List<Item5>
            {
                new Item5 { ItemName = "bat", Price = 30.34},
                new Item5 { ItemName = "ball", Price = 75.23 },
            };

                var queryResult = orders
                    .Join(items, order => order.ItemName, item => item.ItemName, (order, item) => new { order, item })
                    .GroupBy(result => new { Month = result.order.OrderDate.Month, result.order.OrderId, result.order.ItemName, result.order.OrderDate })
                    .OrderByDescending(groupedOrders => groupedOrders.Key.OrderDate)
                    .Select(groupedOrders => new
                    {
                        groupedOrders.Key.OrderId,
                        groupedOrders.Key.ItemName,
                        groupedOrders.Key.OrderDate,
                        TotalPrice = groupedOrders.Sum(o => o.order.Quantity * o.item.Price)
                    });

                // Displaying the result
                foreach (var result in queryResult)
                {
                    Console.WriteLine($"Order ID: {result.OrderId}, Item Name: {result.ItemName}, Order Date: {result.OrderDate}, Total Price: {result.TotalPrice}");
                }
            }
        }
    }
   
}
