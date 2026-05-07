using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int contador1 = 0;
            int contador = 0;
            for (int i = 1; i <= numero; ++i)
            {
              
                

                if (numero % i == 0)
                {
                    contador++;
                    contador1++;
                    if (contador1 == 2)
                    {
                        Console.Write(i+ "  Es primo el primer divisor ");

                    }
                  
                }

              
            }
        if (contador ==2)
            {
                Console.WriteLine(numero+ " Es primo  ");

            }
        else
            {
                Console.Write("No es primo  ");

            }



        }
        }
}









       
