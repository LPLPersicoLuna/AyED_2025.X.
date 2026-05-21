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
            int nota, contador, Promedio;
           
             Promedio= 0 ;
             contador = 0;
            do
            {
                Console.Write("nota");
                nota = int.Parse(Console.ReadLine());
                Promedio += nota;
                contador += 1;
            } while (contador < 5);
            int promedioReal;
            promedioReal = Promedio / 5;
            Console.WriteLine("Promedio : " + Promedio + promedioReal );






        }
    }
}
