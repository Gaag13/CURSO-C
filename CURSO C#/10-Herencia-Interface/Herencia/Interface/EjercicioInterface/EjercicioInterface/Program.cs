using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterface
{
    internal class Program
    {
        //Crear avisos usando INTERFACE 
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial", "sancion de velocidad 300 EUR", "02-05-20");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();


        }

    }
}
