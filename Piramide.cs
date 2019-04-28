using System;
using System.Collections.Generic;
using System.Text;

//5.	Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de asteriscos.
//Por ejemplo, si se introduce el 6, el resultado sería
//         *
//        ***
//       *****
//      *******
//     *********
//    ***********


namespace AndersónPlua3B.PROGRAMAS
{
    class Piramide
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("altura piramide: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
