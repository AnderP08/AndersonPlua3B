using System;
using System.Collections.Generic;
using System.Text;

//3.	Crear un programa que lea cantidades y precios y al final indique el total de la factura.
//Primero se pregunta: 
//Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.
//Después se pregunta:
//Introduzca el precio que será un número decimal positivo.
//La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total.

namespace AndersónPlua3B.PROGRAMAS
{
    class Factura
    {
        static void Main(string[] args)
        {
            double TOTALES = 0;
            double total = 0;
            int cant;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese cantidad"); //Se ingresa la cantidad de productos
                    cant = Convert.ToInt32(Console.ReadLine());
                    if (cant < 0) Console.WriteLine("cantidad no valida");
                    if (cant > 0)
                    {
                        Console.WriteLine("Ingrese precio");    //Se ingresa precio
                        double precio = Convert.ToInt32(Console.ReadLine());
                        total = cant * precio;
                        TOTALES = TOTALES + total;
                    }
                } while (cant < 0);
            } while (cant != 0);

            Console.WriteLine("Total Factura: " + TOTALES);
            Console.ReadKey();
        }
    }
}