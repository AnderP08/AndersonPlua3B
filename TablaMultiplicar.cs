using System;
using System.Collections.Generic;
using System.Text;

//9.	Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15.

namespace AndersónPlua3B.PROGRAMAS
{
    class TablaMultiplicar
    {
        static void Main(string[] args)
        {
            int num, resul;
            String teclado;

            Console.WriteLine("Ingrese numero");
            teclado = (Console.ReadLine());
            num = Convert.ToInt32(teclado);

            for (int i = 1; i <= 15; i++)
            {
                resul = num * i;
                Console.WriteLine(num + " * " + i + " = " + resul);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
