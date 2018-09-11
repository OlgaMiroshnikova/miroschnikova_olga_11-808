using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//granica
            int x = int.Parse(Console.ReadLine());//first del
            int y = int.Parse(Console.ReadLine());//second del
            int sum = (n - 1) / x + (n - 1) / y - (n - 1) / (x * y);//all numbers
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
