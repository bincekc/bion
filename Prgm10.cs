using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
    class Order5
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }
    internal class Prgm10
    {
        static void Main()
        {
            List<Order5> ordersList = new List<Order5>
        {
            new Order5 { ItemName = "box", Quantity = 12 },
            new Order5 { ItemName = "pencil", Quantity = 33 },
            new Order5  { ItemName = "rubber", Quantity = 5 },
            new Order5  { ItemName = "scale", Quantity = 43 },
            new Order5  { ItemName = "bat", Quantity = 3 },



        };

            // Sum of quantities for each item
            var sumOfQuantities = from order in ordersList
                                  group order by order.ItemName into groupedOrders
                                  select new
                                  {
                                      ItemName = groupedOrders.Key,
                                      TotalQuantity = groupedOrders.Sum(o => o.Quantity)
                                  };

            Console.WriteLine("Sum of quantities for each item:");
            foreach (var itemSum in sumOfQuantities)
            {
                Console.WriteLine($"{itemSum.ItemName}: {itemSum.TotalQuantity}");
            }

            // with overall maximum orders
            var maxOrdersItem = sumOfQuantities.OrderByDescending(item => item.TotalQuantity).FirstOrDefault();

            Console.WriteLine($"Item with overall maximum orders: {maxOrdersItem?.ItemName}");
        }
    }
    
}
