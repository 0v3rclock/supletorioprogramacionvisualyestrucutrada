using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_de_piedra__papel__tijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jugarDeNuevo = true;
            while (jugarDeNuevo)
            {
                Console.WriteLine("!bienvenidos a \"pierda, papel o tijeras\"");
                Console.WriteLine("reglas: \nlas reglas son simples asi que no hay de que preocuparse: \n regla 1: debes elejir un numero del 1 al 3. \n ya que las mismas corresponden a 1 = piedra, 2 = papel, 3 = tijeras");
                Console.WriteLine("ahora elije dificultad:");
                Console.WriteLine("0. facil \n 1. medio \n 2. dificil \n 3. Salir");
                int opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 0:
                        NivelFacil();
                        break;
                    case 1:
                        NivelIntermedio();
                        break;
                    case 2:
                        NivelDificil();
                        break;
                    case 3:
                        jugarDeNuevo = false;
                        Console.WriteLine("Gracias por jugar!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("esta no es una dificultad existente, vuelve a ingresar una dificultad valida");
                        break;
                }
                if (jugarDeNuevo)
                {
                    Console.WriteLine("¿Quieres jugar de nuevo? (s/n)");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta != "s")
                    {
                        jugarDeNuevo = false;
                        
                    }
                }
            }
        }
        public static void NivelFacil()
        {
            Console.WriteLine("Nivel Fácil");
            Console.WriteLine("Elije un número del 1 al 3:");
            int eleccionUsuario = int.Parse(Console.ReadLine());
            Random random = new Random();
            int eleccionComputadora = random.Next(1, 4);
            Console.WriteLine($"La computadora eligió {eleccionComputadora}");

            if (eleccionUsuario == eleccionComputadora)
            {
                Console.WriteLine("Empate!");
            }
            else if ((eleccionUsuario == 1 && eleccionComputadora == 3) ||
                     (eleccionUsuario == 2 && eleccionComputadora == 1) ||
                     (eleccionUsuario == 3 && eleccionComputadora == 2))
            {
                Console.WriteLine("Ganaste!");
            }
            else
            {
                Console.WriteLine("Perdiste!");
            }
            Console.WriteLine("pulse una tecla para continuar...");
            Console.ReadKey();
        }

        public static void NivelIntermedio()
        {
            Console.WriteLine("Nivel Intermedio");
            Console.WriteLine("Elige un número del 1 al 3:");
            int eleccionUsuario = int.Parse(Console.ReadLine());
            Random random = new Random();
            int eleccionComputadora = random.Next(1, 4);
            Console.WriteLine($"La computadora eligió {eleccionComputadora}");

            // En el nivel intermedio, la computadora tiene una pequeña ventaja
            if (eleccionUsuario == eleccionComputadora)
            {
                Console.WriteLine("Empate!");
            }
            else if ((eleccionUsuario == 1 && eleccionComputadora == 3) ||
                     (eleccionUsuario == 2 && eleccionComputadora == 1) ||
                     (eleccionUsuario == 3 && eleccionComputadora == 2))
            {
                // La computadora tiene un 20% de probabilidad de ganar aunque el usuario haya elegido la opción correcta
                if (random.NextDouble() < 0.2)
                {
                    Console.WriteLine("Perdiste!");
                }
                else
                {
                    Console.WriteLine("Ganaste!");
                }
            }
            else
            {
                Console.WriteLine("Perdiste!");
            }
            Console.WriteLine("pulse una tecla para continuar...");
            Console.ReadKey();
        }
        public static void NivelDificil()
        {
            Console.WriteLine("Nivel Difícil");
            Console.WriteLine("Elige un número del 1 al 3:");
            int eleccionUsuario = int.Parse(Console.ReadLine());
            Random random = new Random();
            int eleccionComputadora = random.Next(1, 4);
            Console.WriteLine($"La computadora eligió {eleccionComputadora}");

            // En el nivel difícil, la computadora tiene una gran ventaja
            if (eleccionUsuario == eleccionComputadora)
            {
                Console.WriteLine("Empate!");
            }
            else if ((eleccionUsuario == 1 && eleccionComputadora == 3) ||
                     (eleccionUsuario == 2 && eleccionComputadora == 1) ||
                     (eleccionUsuario == 3 && eleccionComputadora == 2))
            {
                // La computadora tiene un 50% de probabilidad de ganar aunque el usuario haya elegido la opción correcta
                if (random.NextDouble() < 0.5)
                {
                    Console.WriteLine("Perdiste!");
                }
                else
                {
                    Console.WriteLine("Ganaste!");
                }
            }
            else
            {
                Console.WriteLine("Perdiste!");
            }

            // Además, en el nivel difícil, la computadora puede cambiar su elección en un 20% de los casos
            if (random.NextDouble() < 0.2)
            {
                eleccionComputadora = random.Next(1, 4);
                Console.WriteLine($"La computadora cambió su elección a {eleccionComputadora}");
                if ((eleccionUsuario == 1 && eleccionComputadora == 3) ||
                    (eleccionUsuario == 2 && eleccionComputadora == 1) ||
                    (eleccionUsuario == 3 && eleccionComputadora == 2))
                {
                    Console.WriteLine("Ganaste!");
                }
                else
                {
                    Console.WriteLine("Perdiste!");
                }
                Console.WriteLine("pulse una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
