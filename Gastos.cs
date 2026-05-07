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

            int Acumulador = 0;
            int contador = 0;
            for (int i = 1; i <= 5; ++i)
            {
                Console.Write("ingrese sus gastos" + i + ":");

                int Tiem = int.Parse(Console.ReadLine());
                Acumulador = Acumulador + Tiem;
                if (Tiem < 0)
                {
                    contador = contador + 1;

                }
            }
            Console.WriteLine("Los gastos fueron" + Acumulador + "Gastos");


            Console.WriteLine("Los gastos fueron superiores a 500" + Acumulador + "Veces");









        }
    }
}
