using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesExtensiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ejercicio 1 y 2
            int divisor = 0;
            int dividendo = 0;
            string r;
            
            try
            {
                Console.WriteLine("Ingrese el dividendo");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor");
                divisor = Convert.ToInt32(Console.ReadLine());
                Division obj = new Division();
                r = obj.HacerDivision(dividendo, divisor);
                Console.WriteLine("El resultado de {0} dividido {1} es: {2}  \n \n", dividendo, divisor, r);
            } 
            catch (FormatException e)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada! {0}", e.Message);
            } 
            finally
            {
                Console.WriteLine("Lo intentamos... \n \n");
            }

           
            // Ejercicio 3 
            try
            {
                Console.WriteLine("Este es el ejercicio 3");
                Logic ejer = new Logic();
                ejer.Metodo1();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("El método no está implementado :p \n \n", e);
            }


            // Ejercicio 4 
            try
            {
                Console.WriteLine("Este es el ejercicio 4");
                Logic ejer = new Logic();
                ejer.Metodo2();
            }
            catch (CustomException e)
            {
                Console.WriteLine("Esta excepción esta customizada =P", e);
            }

            Console.ReadKey();

        }

    }
}