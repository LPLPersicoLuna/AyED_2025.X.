using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program



    {
        static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);

            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }

            return valor;
        }

        // Pide la cantidad de números a cargar (debe ser mayor a 0)
        static int LeerCantidad()
        {
            int cantidad = LeerEntero("¿Cuántos números desea ingresar?: ");

            while (cantidad <= 0)
            {
                cantidad = LeerEntero("La cantidad debe ser mayor a 0. Ingrese nuevamente: ");
            }

            return cantidad;
        }

        // Carga los números ingresados por el usuario en un arreglo
        static int[] CargarNumeros(int cantidad)
        {
            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = LeerEntero("Ingrese el número {i + 1}: ");
            }

            return numeros;
        }

        // Cuenta cuántas veces aparece un valor en el arreglo
        static int ContarApariciones(int[] numeros, int valor)
        {
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == valor)
                    contador++;
            }

            return contador;
        }

        // Devuelve la frecuencia máxima (cuántas veces se repite el más repetido)
        static int ObtenerFrecuenciaMaxima(int[] numeros)
        {
            int maxima = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                int frecuencia = ContarApariciones(numeros, numeros[i]);

                if (frecuencia > maxima)
                    maxima = frecuencia;
            }

            return maxima;
        }

        // Indica si el número de la posición dada ya apareció antes en el arreglo
        static bool YaApareciaAntes(int[] numeros, int posicion)
        {
            for (int i = 0; i < posicion; i++)
            {
                if (numeros[i] == numeros[posicion])
                    return true;
            }

            return false;
        }

        // Muestra todos los números que tienen la frecuencia máxima, sin repetirlos
        static void MostrarMasFrecuentes(int[] numeros, int frecuenciaMaxima)
        {
            Console.WriteLine("Números que mss veces aparecióeron:");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (!YaApareciaAntes(numeros, i) &&
                    ContarApariciones(numeros, numeros[i]) == frecuenciaMaxima)
                {
                    Console.WriteLine(" numeros"+numeros);
                }
            }

            Console.WriteLine($"\nCantidad de veces que se repitió: {frecuenciaMaxima}");
        }

        static void Main(string[] args)
        {
            int cantidad = LeerCantidad();
            int[] numeros = CargarNumeros(cantidad);

            int frecuenciaMaxima = ObtenerFrecuenciaMaxima(numeros);
            MostrarMasFrecuentes(numeros, frecuenciaMaxima);
        }
    }
}
