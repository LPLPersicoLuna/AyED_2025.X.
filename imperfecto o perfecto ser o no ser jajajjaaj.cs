using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
       
        
            static bool perfecto(int numero)
        {
                int sumaDivisores = 0;


                for (int i = 1; i < numero; i++)
                {

                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }


                return sumaDivisores == numero;
            }

            static void Main(string[] args)
        {
                enteros();
            }


            static void enteros()
        {
                Console.Write("Ingrese un número entero positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());


                if (numero <= 0)
                {
                    Console.WriteLine("¡Error! Debe ingresar un número mayor a cero.");
                }
                else
                {

                    if (perfecto(numero))
                    {
                        Console.WriteLine("El número " + numero + " es perfecto");
                    }
                    else
                    {
                        Console.WriteLine("El número " + numero + " NO es perfecto");
                    }
                }

                Console.ReadLine();
            }
        }








    }








   
