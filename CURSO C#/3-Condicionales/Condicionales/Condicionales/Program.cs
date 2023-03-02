using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.0_CONDICIONAL IF I
            //bool haceFrio = false;
            //Console.WriteLine(haceFrio);

            //Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            //int edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{

            //    Console.WriteLine("Adelante puedes pasar porque eres mayor de edad");
            //}
            #endregion

            #region 2.0_CONDICIONAL IF II

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            //bool carnet = true;

            //if (carnet)
            //{
            //    Console.WriteLine("Puedes conducir vehiculos");
            //}
            //else
            //{
            //    Console.WriteLine("Lo siento pero no puedes conducir vehiculos");
            //}
            //Console.WriteLine("Aqui termina el programa");

            #region SEGUNDO EJEMPLO IF
            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            //Console.WriteLine("Introducee tu edad, por favor");

            //int edad =int.Parse(Console.ReadLine());

            //Console.WriteLine("¿Tienes carnet?");

            //string carnet = Console.ReadLine();

            //if(edad>= 18 && carnet=="si")
            //{
            //    Console.WriteLine("Puedes conducir vehiculos");
            //}
            //else
            //{
            //    Console.WriteLine("No puedes conducir vehiculos");
            //}
            #endregion
            #endregion

            #region 3.0_CONDICIONAL IF III

            #region PRIMER METODO
            //string carnet = "no";
            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            //Console.WriteLine("Introducee tu edad, por favor");

            //int edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine("¿Tienes carnet?");

            //    carnet = Console.ReadLine();
            //}
            //if (edad >= 18 && carnet == "si")
            //{
            //    Console.WriteLine("Puedes conducir vehiculos");
            //}
            //else
            //{
            //    Console.WriteLine("No puedes conducir vehiculos");
            //}
            #endregion

            #region SEGUNDO METODO
            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            //Console.WriteLine("Introducee tu edad, por favor");

            //int edad = int.Parse(Console.ReadLine());

            //if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");

            //else
            //{
            //    Console.WriteLine("¿Tienes carnet?");

            //    string carnet = Console.ReadLine();

            //    int compara = string.Compare(carnet, "si", true);

            //    if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

            //    else Console.WriteLine("Lo siento mucho no puedes conducir");
            //}
            #endregion

            #region TERCER METODO

            //Console.WriteLine("INTRODUCE LA NOTA DEL PRIMER PARCIAL");

            //int parcial1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("INTRODUCE LA NOTA DEL SEGUNDO PARCIAL");

            //int parcial2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("INTRODUCE LA NOTA DEL TERCERO PARCIAL");

            //int parcial3 = int.Parse(Console.ReadLine());

            //if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            //{
            //    Console.WriteLine("La nota media es " + (parcial1 + parcial2 + parcial3) / 3);
            //}
            //else Console.WriteLine("Vuelve en septiembre");
            #endregion

            #region CUARTO METODO

            Console.WriteLine("INTRODUCE TU EDAD");

            //int edad = int.Parse(Console.ReadLine());

            //if (edad < 18) Console.WriteLine("Eres un niño");

            //else if (edad < 30) Console.WriteLine("Eres un joven");

            //else if (edad < 60) Console.WriteLine("Eres un adulto");

            //else Console.WriteLine("Debes cuidarte ya");


            #endregion

            #region QUINTO METODO [SWITCH]

            Console.WriteLine("Elige medio de transporte (coche, tren, avion)");
            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media : 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media : 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidadad media . 800 km/h");
                    break;

                default:
                    Console.WriteLine("Trasporte no contemplado");
                    break;
            }
            //*************************************************************************************************



            #endregion


            #endregion




        }
    }
}
