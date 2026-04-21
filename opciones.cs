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
            // SITUACION
            Console.WriteLine("si ten encuentras un cristal keyber perdido ");
            Console.WriteLine("¿ Que haces ? ");

            //OPCIONDES
            Console.WriteLine(" 1. Lo devuelves al templo.");
            Console.WriteLine(" 2. Lo vendes por créditos.");
            Console.WriteLine("3. Lo usas para construir un arma roja . ");

            Console.WriteLine(" Ingresa las opciones ");
            int a = Convert.ToInt32(Console.ReadLine());

            //RESPUESTA

            if (a <= 1)
            {
                Console.WriteLine("El camino del Jedi sigue");

                if (a <= 2)
                {
                    Console.WriteLine("Un cazarrecompensas eres");
                }

            }
            if (a <= 3)
            {
                Console.WriteLine("El Lado Oscuro se apodera de ti");
            }
            else 
                    {
                Console.WriteLine("Error en la Fuerza: opción inválida");
            }
        }
    }
  }
