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
            int nota;

            do
            {
                Console.WriteLine(" Nota del examen: ");
                nota = Convert.ToInt32(Console.ReadLine());
            } while (nota > 0 && nota > 10);


            if (nota < 10 && nota < 0)
            {
                Console.WriteLine("ERROR VUELVA INGRESAR");

            }

            else
            {
                Console.WriteLine(" esta bien:");
            }




        }
    }
}
