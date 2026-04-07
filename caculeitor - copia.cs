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

            Console.WriteLine("Ingresa valor de a");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa valor de b");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            int suma;
            suma = a + b;
            int Result;
            Result =  a + b;
            Console.Write("El resultado" + a + "mas" + b + "el resultado " + Result +  "." );

            Console.WriteLine("Ingresa valor de a");
         
            //RESTA

            int Resultr;
            Resultr = a - b;

            Console.Write("El resultado" + a + "menos" + b + "el resultado " + Resultr + ".");


            //MULTIPLICACION

            int Resultm;
            Resultm = a * b;

            Console.Write("El resultado" + a + "multiplicacion" + b + "el resultado " + Resultr + ".");


            //DIVISION

            int Resultv;
            Resultv = a * b;

            Console.Write("El resultado" + a + "division" + b + "el resultado " + Resultr + ".");






















        }
    }
}
