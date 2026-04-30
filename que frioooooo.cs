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

            Console.WriteLine("Ingrese temperatura");
            int temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.Write("subi la temperatura que ni el doctor frio puede estar aqui");

            }

            if (temperatura == 0)
            {
                Console.Write("mira que no es cara la clefaccion ");

            }

            if (temperatura == 15)
            {
                Console.Write("mira que no es caro la clefaccion ");

            }
            else
            {
                Console.Write("Esta bien ");

            }
            }
    }
}
