using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Solicitar el número al usuario
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Aseguramos trabajar con el valor absoluto por si ingresan un número negativo
                int numeroAbsoluto = Math.Abs(numero);

                // 2. Llamar a las funciones
                int cantidadDigitos = ContarDigitos(numeroAbsoluto);
                bool esCapicua = EsCapicua(numeroAbsoluto);

                // 3. Informar los resultados
                Console.WriteLine($"\nLa cantidad de dígitos que posee el número es: {cantidadDigitos}");

                if (esCapicua)
                {
                    Console.WriteLine("El número ES capicúa.");
                }
                else
                {
                    Console.WriteLine("El número NO es capicúa.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }
        }

        // Función para contar la cantidad de dígitos de un número
        static int ContarDigitos(int num)
        {
            if (num == 0) return 1;

            int contador = 0;
            while (num > 0)
            {
                contador++;
                num /= 10; // Elimina el último dígito
            }
            return contador;
        }

        // Función para determinar si un número es capicúa
        static bool EsCapicua(int num)
        {
            int numeroOriginal = num;
            int numeroInvertido = 0;

            // Invertimos el número matemáticamente
            while (num > 0)
            {
                int ultimoDigito = num % 10;
                numeroInvertido = (numeroInvertido * 10) + ultimoDigito;
                num /= 10;
            }

            // Si el invertido es igual al original, es capicúa
            return numeroOriginal == numeroInvertido;
        }
    }



}
    }
}
