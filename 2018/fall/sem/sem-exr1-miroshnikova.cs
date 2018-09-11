using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1//Miroshnikova Olga Exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse (Console.ReadLine());
            int b = int.Parse (Console.ReadLine());
            a = a + b;//swap a and b
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
