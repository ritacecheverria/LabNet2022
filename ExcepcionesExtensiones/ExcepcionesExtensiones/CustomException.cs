using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesExtensiones
{
    public class CustomException : Exception
    {
        

        public CustomException() : base()
        {
        }

        public CustomException(String message) : base(message)
        {
        }

    }
}
