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

            Console.WriteLine(" temperatura: ");



            Console.Write(" Ingresa la temperatura porfavor");
             int temperatura = int.Parse(Console.ReadLine());
            
            while (temperatura > 24)
            {
                temperatura--;
                Console.WriteLine("la temperatura: " + temperatura);


            }

            Console.Write(" La temperatura es: ");







        }
    }
}
