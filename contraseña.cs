using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Igrese contraseña : ");
            string Contraseña = (Console.ReadLine());
            string Contraseñaoficial;

            do
            {
                Console.Write(" revise la Contraseña : ");
                Contraseñaoficial = (Console.ReadLine());
                if (Contraseña != Contraseñaoficial)
                {
                    Console.Write("  ERROR DE CONTRASEÑA : ");
                }
            } while (Contraseña != Contraseñaoficial);

            Console.Write("  Contraseña validad prosigue : ");

        }
    }
}
