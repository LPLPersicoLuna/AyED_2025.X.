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
            Console.WriteLine("Hola Mando");
            Console.WriteLine("Analizando kg");
            int x;
            x =Convert.ToInt32(Console.ReadLine());


            if (x <= 5000)

                Console.WriteLine("Despegue autorizado.Buen viaje, Mando");

            
                 else
                    Console.WriteLine( "NO PUEDE DESPEGAR DEBE DECARGAR EL PESO " );


            int Resta;
            Resta = 5000 - x ;
            int Result;
            Result = x - 5000;
            Console.Write("El resultado"  + x  +  "menos" + 5000 +  "el resultado "  + Result  + ".");



        }
    }
}
