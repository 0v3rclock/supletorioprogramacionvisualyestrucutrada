using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace supletorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero para validar el valor: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 0 && num1 <= 10)
            {
                Console.WriteLine($"el numero es menor o igual a 10. {num1}");
            }
            else if (num1 == 11 && num1 <= 20)
            {
                Console.WriteLine($"el numero es menor o igual a 20. {num1}");
            }
            else
            {
                Console.WriteLine($"el numero es mayor a 20. {num1}");
            }
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
