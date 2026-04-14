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
            Console.WriteLine("Jawa: tututatuititu  ( cuantos droides quiere )");
            Console.WriteLine("el cliente dice cuantos quiere");
            int androide = Convert.ToInt32(Console.ReadLine());


            int totalapagar;
            totalapagar = androide + 2000;
            int Result;
            Result = androide  + 2000 ;
            Console.Write("El resultado" + androide + "mas" + 2000 + "el resultado " + Result + ".");

            if  ( androide > 3)
            { int resultr;
               resultr = Result *20 /100;
            Console.WriteLine("mostrar el total original" + totalapagar + "el ahorro y el preciofinal." + resultr  );
            }
            else
            { Console.WriteLine("mostrar el total original" + totalapagar);  }

        }













    }
    }
