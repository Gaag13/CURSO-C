using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        //Definicion del objeto delegado
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola acabo de llegar. Que tal?");
        }
    }
    class MensajeDespedida
    {    
        public static void SaludoDespedida()
        {
            Console.WriteLine("Hola ya me marcho");
        }
    }
}
