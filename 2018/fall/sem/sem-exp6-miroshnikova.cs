using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = int.Parse(Console.ReadLine());
            int y0 = int.Parse(Console.ReadLine());//tohka
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());//first tohka line
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());//second tohka line
            double road = Math.Abs((y2 - y1) * x0 - (x2 - x1) * y0 + x2 * y1 - y2 * x1) / Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));//formula
            Console.WriteLine(road);
            Console.ReadKey();
        }
    }
}
