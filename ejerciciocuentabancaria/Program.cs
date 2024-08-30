using System;
using System.Threading;

public class CuentaBanco
{
    private string _nombre;
    private string _apellido;
    private decimal _saldo;

    public CuentaBanco(string nombre, string apellido, decimal saldoInicial)
    {
        _nombre = nombre;
        _apellido = apellido;
        _saldo = saldoInicial;
    }

    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            _saldo += cantidad;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: {_saldo}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor a 0.");
        }
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= _saldo)
        {
            _saldo -= cantidad;
            Console.WriteLine($"Retiro exitoso. Nuevo saldo: {_saldo}");
        }
        else
        {
            Console.WriteLine("La cantidad a retirar debe ser mayor a 0 y no exceder el saldo actual.");
        }
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo actual: {_saldo}");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_nombre}");
        Console.WriteLine($"Apellido: {_apellido}");
        Console.WriteLine($"Saldo: {_saldo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBanco cuenta = new CuentaBanco("Jose", "Mosquera", 500);

        Console.WriteLine("1. Depositar");
        Console.WriteLine("2. Retirar");
        Console.WriteLine("3. Consultar saldo");
        Console.WriteLine("4. Mostrar información");
        Console.WriteLine("5. Salir");

        int opcion;
        do
        {
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la cantidad a depositar: ");
                    decimal cantidadDepositar = Convert.ToDecimal(Console.ReadLine());
                    cuenta.Depositar(cantidadDepositar);
                    break;
                case 2:
                    Console.Write("Ingrese la cantidad a retirar: ");
                    decimal cantidadRetirar = Convert.ToDecimal(Console.ReadLine());
                    cuenta.Retirar(cantidadRetirar);
                    break;
                case 3:
                    cuenta.ConsultarSaldo();
                    break;
                case 4:
                    cuenta.MostrarInformacion();
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                    break;
            }
        } while (opcion != 5);
    }
}