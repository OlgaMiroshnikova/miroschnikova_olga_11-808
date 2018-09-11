using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = (b / 4 - a / 4) - (b / 100 - a / 100) + (b / 400 - a / 400);//n is years = весокосные - кратные 100 + кратные 400
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
