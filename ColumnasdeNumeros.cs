using System;
using System.Collections.Generic;
using System.Text;

//7.	Crear un programa que escriba dos columnas de números,
//en la primera se colocan los números del 1 al 100, en la segunda los números del 100 al 1 

namespace AndersónPlua3B.PROGRAMAS
{
    class ColumnasdeNumeros
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + "    " + (101 - i));
            }
            Console.ReadKey();
        }
    }
}
