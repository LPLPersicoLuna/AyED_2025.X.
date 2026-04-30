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
            string nombre;
            string admin;

            Console.WriteLine(" hola querido usario ");
            Console.WriteLine("Ingrese nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña ");
            int contraseña = Convert.ToInt32(Console.ReadLine());
            

            if ("nombre" == "admin") 
            {


                Console.WriteLine(" Hola" + nombre + "La contraseña es" + 1234 + "PUEDE INGREAS" );

            }
            else
            {
                Console.WriteLine("Estas haciendo pasar por el admin  que mal" );


            }


        }
    }
}
