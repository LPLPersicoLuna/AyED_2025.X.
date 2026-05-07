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
            

            int Acumulador = 0;
            int contador = 0;
            for (int i = 1; i <= 7; ++i)
            {
                Console.Write("ingrese a la temperatura " + i + ":" );

                int Tiem = int.Parse(Console.ReadLine());
                Acumulador = Acumulador + Tiem;
                if (Tiem < 0)
                {
                    contador = contador + 1;

                }
            }
                    Console.WriteLine("La temperatura fue" + Acumulador + "Grados");

                Console.WriteLine("La temperatura fue menor a 0" + Acumulador + "Veces");
            }
    }
}
