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
            
            // EDAD Y NOMBRE
            Console.WriteLine("Ingresa nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa edada");
            int edad = Convert.ToInt32(Console.ReadLine());

            //PASA O  NO PASA
            if ( edad > 18 )
                Console.WriteLine("Bienvenido al club" +   nombre  );

            else
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
 

        }
    }
}
