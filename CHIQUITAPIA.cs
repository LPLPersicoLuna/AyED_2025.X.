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
          //INGRESA VALORES DE MINUTOS 
            Console.WriteLine("Ingresa valor de minutos ");
            int minutos;
            minutos = Convert.ToInt32(Console.ReadLine());


           // DIVISION DE HORAS 

            int horas;
            horas = minutos / 60;

            int Resulth;
            Resulth = minutos / 60;

            // DIVISION DE MINUTOS

            int Resultm;
            Resultm = minutos % 60;

            //INGRESO DE VALORES ADICIONALES 

            Console.WriteLine("Ingresa valor del costo total de horas  ");
            int costototalh;
            costototalh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa valor del costo total de minutoss  ");
            int costototalm;
            costototalm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa valor del IVA ");
            int iva;
            iva = Convert.ToInt32(Console.ReadLine());

            // SUMA COSTO TOTAL

            int suma;
            suma = costototalh + costototalm;
            int Resul;
            Resul = costototalh + costototalm;

















        }
    }
}
