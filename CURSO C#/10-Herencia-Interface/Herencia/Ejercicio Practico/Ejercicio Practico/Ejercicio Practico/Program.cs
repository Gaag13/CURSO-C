
#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Practico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion Boieng = new Avion();

            Boieng.ArrancarVehiculo();

            Coche RayoMc = new Coche();

            RayoMc.Terrestre();
            RayoMc.PararVehiculo();


        }
    }
    class Vehiculos
    {
        public void ArrancarVehiculo()
        {
            Console.WriteLine(" Este vehiculo siempre va arrancar");
        }
        public void PararVehiculo()
        {
            Console.WriteLine("Este vehiculo siempre va a parar");
        }
    }
    class Avion : Vehiculos
    {
        public void Volar()
        {
            Console.WriteLine("Este vehiculo puede volar");
        }

    }
    class Coche : Vehiculos
    {
        public void Terrestre()
        {
            Console.WriteLine("Este vehiculo puedo andar por el suelo");
        }
    }

}
