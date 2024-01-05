namespace AssignmentOfLinQ
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                int[] n = { 4, 5,7,11, 13, 99, 39, 74, 65, 12 };
                var reslt = from i in n
                          let y = i * i * i
                          where y > 100 && y < 1000
                          select y;
                foreach (var item in reslt)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

