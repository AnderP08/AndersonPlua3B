using System;
using System.Collections.Generic;
using System.Text;

//1.	Programa que lea una serie de números por teclado e indique cuál es el mayor.

namespace AndersónPlua3B.PROGRAMAS
{
    class NumMayor

    {
        static void Main(string[] args)
        {

            int mayor = 0;

            Console.WriteLine("Ingrese cantidad: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese dato numerico " + (i + 1) + ":");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor > mayor)
                {
                    mayor = valor;
                }
            }

            Console.WriteLine("El valor mayor es: "+ mayor);
            Console.ReadKey();
        }
    }
}