using System;
using System.Collections.Generic;
using System.Text;

//4.	Crear un programa para calcular el salario semanal de unos empleados
//a los que se les paga 15 dólares por hora si éstas no superan las 35 horas.
//Cada hora por encima de 35 se considerará extra y se paga a 22 dólares.
//El programa pide las horas del trabajador y devuelve el salario que se le debe pagar.
//Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite.

namespace AndersónPlua3B.PROGRAMAS
{
    class Salario
    {
        static void Main(string[] args)
        {
            int PagoxHora = 15, Sueldoextra = 22, Total35 = 525, TotalAPagar;
            int ban = 0;
            string respuesta = " ";

            while (ban != 1)
            {
                Console.WriteLine("Ingrese horas trabajadas");
                int Horas = Convert.ToInt32(Console.ReadLine());

                if (Horas <= 35)    {
                    TotalAPagar = Horas * PagoxHora;    }
                else {
                    TotalAPagar = Total35 + ((Horas - 35) * Sueldoextra);   }

                Console.WriteLine("Total a Pagar: " + TotalAPagar);

                Console.WriteLine("¿Va a ingresar dato nuevo?");
                respuesta = Console.ReadLine();

                if (respuesta == "si") { }
                else {
                    ban = 1; }
                Console.ReadKey();
            }
        }
    }
}