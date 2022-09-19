using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesExtensiones
{
    public class Division
    {
        public string HacerDivision(int dividendo, int divisor)
        {
            int a = dividendo;
            int b = divisor;
            int resultado;

            try
            {
                resultado = a / b;
                return resultado.ToString();
            }
            catch (DivideByZeroException e)
            {
                return $"Solo Chuck Norris divide por 0!. {e.Message}";
            }
            finally
            {
               Console.WriteLine("Mmmm... Estamos intentando resolver esto");
            }
      
        }
    }
    



}
