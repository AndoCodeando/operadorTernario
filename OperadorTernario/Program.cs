using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {

            // try-catch si el valor ingresado no es numérico
            try
            {
                // Pedimos al usuario su edad
                Console.WriteLine("Escriba su edad:");

                // Guardamos el valor en una variable
                int edad = int.Parse(Console.ReadLine());

                // Forma usual con if...else

                //if (edad > 18)
                //    Console.WriteLine("Es Usted mayor de edad");
                //else
                //    Console.WriteLine("Tú eres menor de edad");

                // Operador ternario
                Console.WriteLine((edad > 18) ? "Es Usted mayor de edad" : "Tú eres menor de edad");
            }
            catch (Exception ex)
            {
                // Error
                Console.WriteLine("El valor ingresado no es correcto");
            }
            finally
            {
                // Espera al final de la ejecución
                Console.ReadLine();
            }
        }
    }
}
