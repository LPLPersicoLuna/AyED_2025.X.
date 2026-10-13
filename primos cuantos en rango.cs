using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static bool ElPrimo(int numero)
        {
            if (numero < 2)
                return false;
            if (numero == 2)
                return true;
            if (numero % 2 == 0)
                return false;

            for (int i = 3; i * i <= numero; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        static int ELEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);

            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }

            return valor;


        }
        static int MostrarPrimoRango(int inicio, int fin)

        {
            int cantida = 0;

            Console.Write("Numeros primos astá" + inicio + fin);
            for (int i = inicio; i <= fin; i++)
            {
                if (ElPrimo(i))
                {
                    Console.Write(i + " ");
                    cantida++;
                }
            }

            if (cantida == 0)
                Console.Write("No se esnocontro numeros primos:");

            else
                Console.Write("Si se encontaron");
            return cantida;
        }

        static void Main(string[] args)
        {
            int a = ELEntero("Ingrese el primer número del rango: ");
            int b = ELEntero("Ingrese el segundo número del rango: ");

            int inicio = Math.Min(a, b);
            int fin = Math.Max(a, b);

            int total = MostrarPrimoRango(inicio, fin);
            Console.Write(" Cantida de numeros Primos encontrados: " + total);
        }
    }
}