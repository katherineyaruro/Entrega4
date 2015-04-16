using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTry
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Controlar y mostrar el error que captura el catch cuando se intenta 
             * dividir por cero, tambien imprimir la propiedad stack trace de la
             * ecepcion.*/

            int numero, resultado;
            Console.WriteLine("Digite Numero");
            numero = int.Parse(Console.ReadLine());
            int numero2=1;
            numero2--;
            try
            {
                resultado = numero/numero2;
            }
            catch (Exception error) 
            {
                Console.WriteLine("El ERROR es" + error.Message);
            }
            Console.ReadLine();

        }
    }
}
