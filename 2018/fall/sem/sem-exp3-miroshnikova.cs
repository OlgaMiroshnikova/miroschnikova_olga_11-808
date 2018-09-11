using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());//hour
            h = (30 * h) % 360;
            if (h > 180)  h = 180 - (h % 180);// in les side
            Console.WriteLine(h);
            Console.ReadKey();
             
        }
    }
}
