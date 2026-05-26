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

            Console.WriteLine(" hola querido comenzal:");
            Console.WriteLine(" hoy tenemos dos ricos platos  como los principales");
            int platos  = int.Parse(Console.ReadLine());
            Console.WriteLine("1 primero es un bife de carne con pure");
            Console.WriteLine("2 segundo es una pasta carbonada ");

            do
            {
                if (platos <= 1)
                {
                    Console.WriteLine("Aqui tiene espero que lo difruten avisen cualquier cosa : ");

                    if (platos <= 2)
                    {
                        Console.WriteLine("Aqui tiene espero que lo difruten avisen cualquier cosa : ");





                    }



                }

            } while (platos <= 3);

            Console.Write("espero que les haya gustados");


        }
    }
}
