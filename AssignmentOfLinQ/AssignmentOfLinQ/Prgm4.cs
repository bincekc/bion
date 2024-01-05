using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
    internal class Prgm4
    {
        static void Main(string[] args)
        {
            List<Order> list = new List<Order>()
            {
                new Order (1,"Watch",DateTime.Parse("02/23/2015"),10),
                new Order (2,"shirt",DateTime.Parse("06/20/2020"),20),
                new Order (3,"pant",DateTime.Parse("07/20/2023"),25),
                new Order (4,"phone",DateTime.Parse("01/22/2024"),7),
                 new Order (5,"Headset",DateTime.Parse("05/02/2023"),5)
            };
            var s = list.OrderByDescending(a => a.Orderdate.Month);
            foreach (var o in s)
            {
                Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.Orderdate.ToShortDateString()} Quantity:{o.Quantity}");
            }
        }
    }
}

