using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practicovideo
{
    internal class Coche : Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }
        public override void Conducir()                                      //Metodo virtual "conducir"
        {
            Console.WriteLine("Tomando curvas con descision");
        }
       
        /** Los metodos override los metodos conducir de coche y de avion se adaptan a cada objeto, hace que al heradar un metodo este se pueda comoportar como
         * queramos en cada caso,sobreescribiendo
         * * */

    }
}
