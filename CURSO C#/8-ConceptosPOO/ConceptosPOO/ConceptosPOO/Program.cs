using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();
            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miOtraVariable = new { Nombre = "Ana",Edad = 25, };

            miVariable = miOtraVariable;


        }

        static void realizarTarea()
        {
            Punto origen = new Punto();     
            
            Punto destino = new Punto(130,5);

            Punto otroPunto = new Punto();

            double distancia=origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los dos puntos es   {distancia}");

            Console.WriteLine($"Numero de objetos creados : {Punto.ContadorDeObjetos()}");
        }

    }
}
