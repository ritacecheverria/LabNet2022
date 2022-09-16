using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_POO
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Este taxi avanza con {pasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            return $"Este taxi se detiene con {pasajeros} pasajeros";    
        }

    }
}
