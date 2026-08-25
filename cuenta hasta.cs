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
            ContarHasta();
        }

        static void ContarHasta()

        {

            int contador = 1;
            
            int numero = 0;

            Console.WriteLine("Ingrese numero entero:");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero < 10)
            {
                numero = numero + 1;
                Console.WriteLine(numero);
               contador++;
            }
           
            



        }
    }
}
