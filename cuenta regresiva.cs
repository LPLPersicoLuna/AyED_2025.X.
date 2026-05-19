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

            Console.WriteLine(" Ingrese numero entero y positivo porfavor");
            int numero = Convert.ToInt32(Console.ReadLine());
            while (numero > 0)
            {
                Console.WriteLine("numero:" + numero);
                numero--;
            }

            

        }
    }
}
