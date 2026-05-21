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
            Console.WriteLine(" Al cansia");
            int Alcansia = 0;
            int ingresos;

            do
            {
                Console.WriteLine("ingrese sus ingresos");
                ingresos = Convert.ToInt32(Console.ReadLine());

                
                Alcansia = Alcansia + ingresos;

            } while (ingresos != 0);
            Console.WriteLine("Tus ingresos totales" + Alcansia);



        }
    }
}
