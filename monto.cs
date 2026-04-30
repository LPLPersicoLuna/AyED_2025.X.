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
            Console.WriteLine("Ingremontoporfavor ");
            int monto = Convert.ToInt32(Console.ReadLine());
            {
                if (monto > 5000)
                {


                    int descuento = monto % 15;
                    Console.WriteLine("Total a pagar " + descuento);
                }


                else
                {
                    Console.WriteLine(" total a pagar por no su perar 5000 ");
                }




            }
        }
    }
}
