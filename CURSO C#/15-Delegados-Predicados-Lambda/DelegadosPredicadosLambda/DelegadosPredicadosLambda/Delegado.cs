using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambda
{
    internal class Delegado
    {
        //static void Main(string[] args)
        //{
        //    //ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

        //    //// Llamada Utilizacion del delegado para llamar al metodo SaludBienvenida
        //    //ElDelegado("Hola acabo de llegar");

        //    //ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

        //    //ElDelegado("Como vais, esto es llamado");
                                
        //}
        //Definicion del objeto delegado 

        delegate void ObjetoDelegado(string msj);
        
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj )
        {
            Console.WriteLine("Mensaje de bienvenida: {0}", msj);
            
        }
    }
    class MensajeDespedida
    {    
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Hola ya me marcho : {0}",msj);
        }
    }
}
