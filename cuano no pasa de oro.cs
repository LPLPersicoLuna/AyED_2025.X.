using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        static bool par(int numero)
        {
            return numero % 2 == 0;

        }



        static void Main(string[] args)
        {
            enteros();
        }

        static void enteros()
        {
            // 1. Declaramos todas las variables que necesitamos para el ejercicio
            int contadorPares = 0;
            int contadorImpares = 0;
            int mayor = int.MinValue; // Inicializa con el valor más bajo posible
            int menor = int.MaxValue; // Inicializa con el valor más alto posible
            double suma = 0;
            int cantidadTotal = 0;

            Console.WriteLine("Carga de números. Ingresa 0 para finalizar y ver los resultados.");

            // 2. El bucle se repite indefinidamente hasta que el usuario decida parar
            while (true)
            {
                Console.Write("Ingrese numero entero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                // Condición de salida: si digita 0, se detiene la carga
                if (numero == 0)
                {
                    break;
                }

                // --- PROCESAMIENTO DE LOS DATOS ---

                // Calculamos el Mayor y Menor de forma interactiva
                if (numero > mayor) mayor = numero;
                if (numero < menor) menor = numero;

                // Sumamos y contamos para poder sacar el promedio al final
                suma += numero;
                cantidadTotal++;

                // LLAMAMOS A TU FUNCIÓN 'par' CORRECTAMENTE
                if (par(numero))
                {
                    contadorPares++; // Si la función devuelve true, es par
                }
                else
                {
                    contadorImpares++; // Si la función devuelve false, es impar
                }
            }

            // 3. Al finalizar la carga, calculamos el promedio y mostramos todo
            if (cantidadTotal > 0)
            {
                double promedio = suma / cantidadTotal;

                Console.WriteLine("\n======= RESULTADOS =======");
                Console.WriteLine("El número mayor es: " + mayor);
                Console.WriteLine("El número menor es: " + menor);
                Console.WriteLine("El promedio es: " + promedio);
                Console.WriteLine("Cantidad de números pares: " + contadorPares);
                Console.WriteLine("Cantidad de números impares: " + contadorImpares);
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos.");
            }

            Console.ReadLine(); // Evita que la consola se cierre de golpe
        }
    }
}