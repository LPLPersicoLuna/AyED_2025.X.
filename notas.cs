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
            int[] notas = new int[10];
           
            int proceso= 1;

            for  (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Nota del alumnos: ");
                 notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] <= 6)
                {
                    Console.Write("APROBADOS:" );
                }
                else
                { 
                    Console.Write("PROCESO: " + proceso);

                    while ( proceso < 6)
                  { Console.WriteLine(proceso);
                        proceso++;

                    }
                }




            } 
                

        }
    }
}