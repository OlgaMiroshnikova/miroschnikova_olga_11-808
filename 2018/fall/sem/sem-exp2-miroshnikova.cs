using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string str =Console.ReadLine();
            int a = int.Parse(str);
            a = a / 100 + 10 * (a / 10 % 10) + 100 * (a % 10);//number in other side
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
