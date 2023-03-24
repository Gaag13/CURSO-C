using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y mi nº de tfno es (+34)123-45-67 y mi código postal es 29679";
            string Patron = @"\d";

            // Buscando Patron regular 
            Regex miRegex = new Regex(Patron);

            //Buscando coincidencias y agregando a la coleccion elMatch
            MatchCollection elMatch = miRegex.Matches(frase);

            //recorriendo la coleccion
            if(elMatch.Count > 0)
            {
                Console.WriteLine("Se ha encontrado una J" );
            }
            else
            {
                Console.WriteLine("No se ha encontrado J");
            }
            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado numeros");
            else Console.WriteLine("No se han encontrado numeros");
        }
    }
}
  
