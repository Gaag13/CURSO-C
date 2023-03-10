using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practicovideo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avion");

            Avion miAvion = new Avion();

            miAvion.ArrancaMotor("Tracatratracatra");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("Plooff");

            Console.WriteLine();

            Console.WriteLine("Probando el coche");

            Coche micoche = new Coche();

            micoche.ArrancaMotor("grruuu gruuu");

            micoche.Acelerar();

            micoche.Conducir();

            micoche.Frenar();

            micoche.PararMotor("blueeeff");

            Console.WriteLine();

            Console.WriteLine("Polimorfismo en accion");

            //POLIMOFIRMOS

            Vehiculo mivehiculo = micoche;

            mivehiculo.Conducir();

            mivehiculo = miAvion;

            mivehiculo = miAvion;

            mivehiculo.Conducir();
        }
    }
}
