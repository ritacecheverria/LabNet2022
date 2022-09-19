using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesExtensiones
{
    internal class Logic
    {
       

        public void Metodo1()
        {
            throw new NotImplementedException();
        }

        public void Metodo2()
        {
            throw new CustomException("Esto es un mensaje de error de la clase Custom Exception ;)");
        }
    }
}
