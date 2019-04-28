using System;
using System.Collections.Generic;
using System.Text;

// 10.	Crear un programa que muestre un menú como este:
// 1) Salir
// 2) Sumatorio
// 3) Factorial
// Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba.
//Si se elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial
//(en ambos casos el programa pedirá escribir el número sobre el que se calcula el sumatorio o la factorial).
//Tras calcular el sumatorio o la factorial e indicar el resultado, el programa
//volverá a mostrar el menú y así sucesivamente.

namespace AndersónPlua3B.PROGRAMAS
{
    class Menu
    {
        static void Main(string[] args)
        {
            int seleccion;
            int n, aux = 1;
            double res;
            do
            {
                do
                {
                    Console.Write("1 Salir \n2 Sumatorio \n");
                    Console.Write("3 Factorial \nEscriba su opcion: ");
                    seleccion = Convert.ToInt32(Console.ReadLine());
                } while (seleccion != 1 && seleccion != 2 && seleccion != 3);

                if (seleccion == 2)
                {
                    Console.Write("Escriba el numero para sumatorio: ");
                    n = Convert.ToInt32(Console.ReadLine()); res = 0;
                    for (aux = n; aux >= 1; aux--) res += aux;
                    Console.WriteLine("El sumatorio es: " + res);

                    Console.WriteLine("Pulse cualquier tecla para continuar\n");
                    Console.ReadKey();
                }
                else if (seleccion == 3)
                {
                    Console.Write("Escriba el numero para el factorial: ");
                    n = Convert.ToInt32(Console.ReadLine()); res = 1;
                    for (aux = n; aux >= 1; aux--) res *= aux;
                    Console.WriteLine("El factorial es: " + res);

                    Console.WriteLine("Pulse cualquier tecla para continuar\n");
                    Console.ReadKey();
                }
            } while (seleccion != 1);
            Console.ReadKey();
        }
    }
}
