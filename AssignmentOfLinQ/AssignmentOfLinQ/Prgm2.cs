using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfLinQ
{
    
        class Player
        {
            public Player(string name, string country)
            {
                Name = name;
                Country = country;

            }
            public string Name { get; set; }
            public string Country { get; set; }

        }
        internal class Prgm2
    {
            static void Main()
            {
                List<Player> list1 = new List<Player>()
            {
                new Player("Player1","India"),
                new Player("Player2","south Africa"),
                new Player("Player3","Australia")
            };
                List<Player> list2 = new List<Player>()
            {
                new Player("Player4","UK"),
                new Player("Player5","India"),
                new Player("Player6","US")
            };
                var result = from l1 in list1
                             from l2 in list2
                             where l1.Country != l2.Country
                             select new { i = l1.Name, i2 = l2.Name };
                foreach (var n in result)
                    Console.WriteLine($"{n.i}*{n.i2}");


            }
        }
    }

