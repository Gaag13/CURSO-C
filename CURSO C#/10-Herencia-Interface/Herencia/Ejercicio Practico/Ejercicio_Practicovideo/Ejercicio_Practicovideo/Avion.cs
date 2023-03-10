using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practicovideo
{
    internal class Avion : Vehiculo
    {
        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando");
        }
        public void Despegar()
        {
            Console.WriteLine("Despegando")  ;
        }
        public override void Conducir()                         //Metodo virtual "conducir"
        {
            Console.WriteLine("surcando el cielo");
        }
        /** Los metodos override los metodos conducir de coche y de avion se adaptan a cada objeto, hace que al heradar un metodo este se pueda comoportar como
        * queramos en cada caso,sobreescribiendo
        * * */
    }
}
