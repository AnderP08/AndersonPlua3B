using System;
using System.Collections.Generic;
using System.Text;

//8.	Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas.
//La primera cuenta desde uno hasta el número escrito contando de uno en uno;
//la segunda columna cuenta de dos en dos y la tercera de tres. 

namespace AndersónPlua3B.PROGRAMAS
{
    class TresColumnas
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0;
            Console.Write("Ingrese un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                par = par + 2; impar = impar + 3;
                Console.WriteLine(i + "   " + par + "   " + impar);
            }
            Console.ReadKey();
        }
    }
}