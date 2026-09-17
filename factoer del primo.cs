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

            Console.WriteLine("DESCOMPOSICIÓN EN FACTORES PRIMOS");
            Console.Write("Introduce un número entero mayor que 1: ");


            if (int.TryParse(Console.ReadLine(), out numero) && numero > 1)
            {

                List<int> factoresObtenidos = DescomponerEnPrimos(numero);


                MostrarResultados(numero, factoresObtenidos);
            }
            else
            {
                Console.WriteLine("Error: Por favor, introduce un número entero válido y mayor que 1.");
            }
        }


        static List<int> DescomponerEnPrimos(int n)
        {
            List<int> factores = new List<int>();
            int divisor = 2;

            while (n > 1)
            {

                while (n % divisor == 0)
                {
                    factores.Add(divisor);
                    n /= divisor;
                }
                divisor++;
            }

            return factores;
        }


        static void MostrarResultados(int numero, List<int> factores)
        {
            Console.WriteLine(" descomposición de numero es:");

            string descomposicionTexto = string.Join(" x ", factores);

            Console.WriteLine("numero = descomposicionTexto");
            Console.WriteLine("Cantidad total de factores primos: factores.Count");













        }
    }
}















        }
    }
}
