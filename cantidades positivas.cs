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
            int numero = 0;
            int cantidad = 0;

            Console.Write("ingrese numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese Cntidad:");
            cantidad = Convert.ToInt32(Console.ReadLine());


            Console.Write("¿Cuántos números desea ingresar?: ");
            if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Por favor, ingrese una cantidad válida mayor a cero.");
                return;
            }

            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;


            double sumaPositivos = 0;
            double sumaNegativos = 0;


            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número" + i + ": ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo con este número.");
                    i--;
                    continue;
                }


                if (numero > 0)
                {
                    contadorPositivos++;
                    sumaPositivos += numero;
                }
                else if (numero < 0)
                {
                    contadorNegativos++;
                    sumaNegativos += numero;
                }
                else
                {
                    contadorCeros++;
                }
            }


            Console.WriteLine(" RESULTADOS ");
            Console.WriteLine($"Cantidad de números positivos:" + contadorPositivos);
            Console.WriteLine($"Cantidad de números negativos:" + contadorNegativos);
            Console.WriteLine($"Cantidad de números iguales a cero:" + contadorCeros);


            if (contadorPositivos > 0)
            {
                double promedioPositivos = sumaPositivos / contadorPositivos;
                Console.WriteLine("Promedio de los valores positivos:" + promedioPositivos);
            }
            else
            {
                Console.WriteLine("Promedio de los valores positivos: No se ingresaron números positivos.");
            }

            if (contadorNegativos > 0)
            {
                double promedioNegativos = sumaNegativos / contadorNegativos;
                Console.WriteLine($"Promedio de los valores negativos:" + promedioNegativos);
            }
            else
            {
                Console.WriteLine("Promedio de los valores negativos: No se ingresaron números negativos.");
            }
        }
    }
}
