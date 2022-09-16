using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = new int();
           
            //coleccion de datos
            List<TransportePublico> transporte = new List<TransportePublico>();
                
                //agrego elementos Omnibus y Taxi a la lista
                for (int i = 0; i < 10; i++)
                {
                    if (i < 5)
                    {
                        Console.WriteLine("Ingrese la cantidad de pasajeros del Omnibus");
                        cantidad = Int32.Parse(Console.ReadLine());
                        transporte.Add(new Omnibus(cantidad));
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la cantidad de pasajeros del Taxi");
                        cantidad = Int32.Parse(Console.ReadLine());
                        transporte.Add(new Taxi(cantidad));
                    }
                };
                
                //Muestro lista cargada
                int indiceO = 0;
                int indiceT = 0;
                int e = 0;
                foreach (TransportePublico item in transporte)
                {
                    
                    if (e < 5)
                    {
                        indiceO++;
                        Console.WriteLine("Omnibus Nº {0}: {1} pasajeros", indiceO.ToString(), item.pasajeros);
                    }
                    else
                    {
                        indiceT++;
                        Console.WriteLine("Taxi Nº {0}: {1} pasajeros", indiceT.ToString(), item.pasajeros);
                    }
                    e++;
                };

            //foreach (TransportePublico item in transporte)
            //{
            //    Console.WriteLine(item.Avanzar());
            //    Console.WriteLine(item.Detenerse());
            //}

                Console.ReadKey(); 
        }
    }
}
            
         
    

