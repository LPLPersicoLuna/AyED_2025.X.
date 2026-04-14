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

            Console.WriteLine("Ingresa tus midiclorianos joven padawan");
            int x;
            x = Convert.ToInt32(Console.ReadLine());


            if (x > 15000)

            
                Console.WriteLine("Potencial Maestro Jedi detectado.Avisar al Consejo" + " .");

               if ( x > 5000)
             {
                Console.WriteLine("Aceptable para entrenamiento Padawan");
 
            }


            if (x <= 15000)
            {
                Console.WriteLine("Aceptable para entrenamiento Padawan");

            }



                    else
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza".);
            }
            
                 
                    
           


           

        }
    
