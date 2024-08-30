using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer valor tipo entero para calcular");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo valor tipo entero para calcular");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora ingrese el tipo de operacion a proceder");
            string operacion = Console.ReadLine();
            switch (operacion)
                {
                case "+": Console.WriteLine(num1 + num2);
                    break;
                    case "-": Console.WriteLine(num1 - num2);
                    break;
                    case "*": Console.WriteLine(num1 * num2);
                    break; 
                    case "/": Console.WriteLine(num1 / num2);
                    break;
            }
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
