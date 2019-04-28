using System;
using System.Collections.Generic;
using System.Text;

//6.	Modificar el ejercicio anterior para que aparezca un rombo.

namespace AndersónPlua3B.PROGRAMAS
{
    class Rombo
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("altura piramide: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; n - 1 >= i; i++)
            {
                for (int j = n; j >= i; j--)    {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)    {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)    {
                    Console.Write(" ");
                }
                for (int k = 2 * n - 1; k >= 2 * i - 1; k--)    {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
