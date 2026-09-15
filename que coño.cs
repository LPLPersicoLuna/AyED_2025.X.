using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un número entero mayor que 1: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 1)
            {
                Console.Write($"Factores primos de {numero}: ");

                // Llamada a la función que procesa los factores
                int totalFactores = DescomponerEnFactoresPrimos(numero);

                Console.WriteLine($"\nCantidad total de factores primos: {totalFactores}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero válido y mayor que 1.");
            }
        }

        /// <summary>
        /// Descompone un número en sus factores primos, los muestra en pantalla y cuenta el total.
        /// </summary>
        /// <param name="n">Número a descomponer</param>
        /// <returns>La cantidad total de factores primos encontrados</returns>
        static int DescomponerEnFactoresPrimos(int n)
        {
            int contador = 0;
            int divisor = 2;

            // Iteramos mientras el divisor al cuadrado sea menor o igual a n
            while (divisor * divisor <= n)
            {
                while (n % divisor == 0)
                {
                    Console.Write(divisor + " ");
                    contador++;
                    n /= divisor; // Reducimos el número
                }
                divisor++;
            }

            // Si al final n es mayor que 1, lo que queda también es un factor primo
            if (n > 1)
            {
                Console.Write(n + " ");
                contador++;
            }

            return contador;
        }
    }
}
    }
}
