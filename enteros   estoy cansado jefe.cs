using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static bool esPar(int numero)
        {
            return numero % 2 == 0;
        }

        static void Main(string[] args)
        {
            enteros();
        }


        static void enteros()
        {
            Console.Write("Ingrese el primer número entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int inicio = Math.Min(num1, num2);
            int fin = Math.Max(num1, num2);


            int contadorPares = 0;
            int contadorImpares = 0;
            int sumaTotal = 0;

            Console.WriteLine($"\nNúmeros comprendidos entre {inicio} y {fin}:");

            for (int i = inicio; i <= fin; i++)
            {

                Console.Write(i + " ");


                sumaTotal += i;

                if (esPar(i))
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }


            Console.WriteLine("\n\n======= RESULTADOS =======");
            Console.WriteLine("Suma de todos los valores: " + sumaTotal);
            Console.WriteLine("Cantidad de números pares: " + contadorPares);
            Console.WriteLine("Cantidad de números impares: " + contadorImpares);
            Console.WriteLine("==========================");

            Console.ReadLine();
        }
    }

}



















