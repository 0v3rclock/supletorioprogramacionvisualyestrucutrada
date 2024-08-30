using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero del 1 al 7");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("dia lunes");
                    break;
                    case 2: Console.WriteLine("dia martes");
                    break;
                    case 3: Console.WriteLine("dia miercoles");
                    break; 
                    case 4: Console.WriteLine("dia jueves");
                    break;
                    case 5: Console.WriteLine("dia viernes");
                    break;
                    case 6: Console.WriteLine("dia sabado");
                    break; 
                    case 7: Console.WriteLine("dia domingo");
                    break;
                    default: Console.WriteLine("dicho numero no puede dar un dia, reintentar.");
                    break;
            }
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
