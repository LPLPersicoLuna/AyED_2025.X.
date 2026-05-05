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



            Console.Write(" Ingrese temperatura : ");
            int temperatura = Convert.ToInt32(Console.ReadLine());

            int contador = 0;


            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(i);
            }



            if (temperatura > 0)
            {

               contador = contador+1;
             }
            else
                Console.Write(" Tmeperatura esta muy baja bro");



        }
        }

    }
