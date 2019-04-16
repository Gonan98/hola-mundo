using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            int a, b, suma;
            Console.WriteLine("Ingrese 2 numeros: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.ReadKey();
        }
    }
}
