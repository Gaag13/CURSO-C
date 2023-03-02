using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();                                                        // Crea un objeto o instancia perteneciente a la clase Coche
                                                                                               // Instanciar el elemento con la palabra "new"
            Coche coche2 = new Coche();                                                        // Dar un estado inicial a nuestro coche

            Coche coche3 = new Coche(4500.25,1200.35); 

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            coche3.setExtras(true," cuero ");
            Console.WriteLine(coche3.getExtras());
        }

        #region EXPLICACION DE SPLIT CLASES
        /** Para dividir una clase en trozos, primero se determina que se va a dividir en este caso paso de una clase general llamada
         * "class Coche"  a dos llamadas "partial class Coche"
         * 
         */
        #endregion
        partial class Coche
        {
            public Coche()
            {
                ruedas = 4;

                largo = 2300.5;

                ancho = 0.800;

            }

            public String getInfoCoche()                                                                                            //Metodo getter
            {
                return "Informacion del coche:\n " + "Ruedas:" + ruedas + " Largo: " + largo + "  Ancho:" + ancho;
            }
        }

        partial class Coche 
        { 
            public void setExtras(bool climatizador, String tapiceria)                                                    //metodo setter no devuelve nada
            {
                this.climatizador = climatizador;

                this.tapiceria = tapiceria;

                /** Primer uso -> Diferenciar cuando me refiero a un campo de clase en este caso es "private bool climatizador;" y private String tapiceria;
                 * Cuando quiero hacer referencia a un campo de CLASE deberia utilizar la palabra this delante de ese campo de clase.
                 * Como el anterior codigo.
                 *                   
                 */

            }

            public String getExtras()
            {

                return "Extras del coche : \n " + "Tapiceria: " + tapiceria + "Climatizador.  " + climatizador;

            }


            public Coche(double largoCoche, double anchoCoche)
            {
                ruedas = 4;

                largo = largoCoche;

                ancho = anchoCoche;

                climatizador = true;

            }

            private int ruedas;                                                                // CREANDO LAS VARIABLES QUE VA TENER LA CLASE LLAMADA COCHE

            private double largo;

            private double ancho;

            private bool climatizador;

            private String tapiceria;
        }
    }
}

