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
         //NUMERO
            Console.WriteLine(" Querido usario ingrese numero ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            if (  numero%2 == 0 )

                Console.WriteLine(" Es par  ");

            else
                Console.WriteLine(" Error: Es impar  ");



        }
    }
}
