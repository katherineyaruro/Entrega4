using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50),
             * no olvidar el manejo de errores.*/
            int numero, numero2;
            Console.WriteLine("Tablas de Multiplicar");
            for (numero=5; numero <= 50; numero++) 
            {
                Console.WriteLine("Tablas del" + numero + ":");
                for (numero2 = 0; numero2 <= 10; numero2++) 
                {
                    try
                    {
                        Console.WriteLine(numero + "x" + numero2 + "=" + numero * numero2);
                    }
                    catch (Exception error) 
                    {
                        Console.WriteLine("ERROR");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
