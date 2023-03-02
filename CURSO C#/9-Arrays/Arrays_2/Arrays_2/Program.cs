using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            numeros[0] = 7;
            numeros[1] = 70;
            numeros[2] = 41;
            numeros[3] = 17;

            ProcesaDatos(numeros);
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] arrayElementos = LeerDatos();
            Console.WriteLine("Imprimiendo desde el MAIN");
            foreach (int i in arrayElementos) Console.WriteLine(i);

        }
        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];
            for (int i=0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");
                respuesta = Console.ReadLine();
                int datosElemento= int.Parse(respuesta);
                datos[i] = datosElemento;
                
            }
            return datos;
        }

        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < 4; i++)
            {
                datos[i] += 10;
            }
        }

    }
}
