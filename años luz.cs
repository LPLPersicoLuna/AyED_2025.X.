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


            Console.WriteLine("Ingresa distancia del curzo");
            int añosluz = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la  conbustible disponible");
            int cd = int.Parse(Console.ReadLine());

            if (añosluz * 12 <= cd)
            {
                Console.WriteLine("calculos esxactos, listos para el salto");

            }
            else
            {
                int faltante = (añosluz * 12) - cd;
                Console.WriteLine("calculos inexactos, no se podra dar elsalto luz" + faltante + "litros");

            }













        }
    }
}
