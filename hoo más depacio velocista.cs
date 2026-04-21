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
            // VELOCIDAD
            Console.WriteLine("Ingresa velocidad");
            int a = Convert.ToInt32(Console.ReadLine());

            //MULTA
            if ( a > 120 )
                Console.WriteLine( "Multa en camino: HOO más despacio velocista" );

            else
                Console.WriteLine("Conducción segura");
        }
    }
}
