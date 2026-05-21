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
            Console.Write(" Ingresa  tabla porfavor");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;
            int  multiplicacion = 0;
            while (contador <=12)
            {
                multiplicacion = numero * contador;
                Console.WriteLine(" la tabla es: "  + contador + "=" + multiplicacion);
                contador++;
            }


        }
    }
}
