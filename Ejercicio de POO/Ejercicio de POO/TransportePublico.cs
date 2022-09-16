using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_POO
{
    public abstract class TransportePublico
    {
        //defino propiedad
        public int pasajeros { get; set; }
        
        //constructor
        public TransportePublico (int pasajeros) 
        {
            this.pasajeros = pasajeros;
        }

        //metodos
        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
