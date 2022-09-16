using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_de_POO
{
    public class Omnibus : TransportePublico
    {
        public Omnibus (int pasajeros) : base(pasajeros)
        {
           
        }

        //metodos heredados
        public override string Avanzar()
        {
            return $"Este omnibus avanza con {pasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            return $"Este omnibus se detiene con {pasajeros} pasajeros";
        }
    }
}
