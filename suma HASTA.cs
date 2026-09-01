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
            int numero = 5;
            int resultado = SumarHasta(numero);

            Console.WriteLine("La suma desde 1 hasta" +numero + "es:" + resultado);
        }

       
        static int SumarHasta(int limite)
        {
           
            return (limite * (limite + 1)) / 2;
        }
    }



}
        






    
    
