using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  BUCLE WHILE
            //Console.WriteLine("¿Deseas entrar en el Bucle while?");

            //string respuesta = Console.ReadLine();

            //while (respuesta != "no")
            //{
            //    Console.WriteLine("Estas ejecutando el interior del bucle whilw");

            //    Console.WriteLine("Introduce tu nombre, por favor");

            //    string nombre = Console.ReadLine();

            //    Console.WriteLine($"Saldras del bucle {nombre} cuando respondas 'no' a la pregunta");

            //    Console.WriteLine("¿Deseas repetir otra vez");

            //    respuesta = Console.ReadLine();
            //}

            //Console.WriteLine("Haz salido del bucle");

            #endregion

            #region EJEMPLO WHILE

            //Console.WriteLine("Digite un numero de 0 a 100");

            //int numero1 = 101;


            //Random numero = new Random();

            //int numeroAleatorio = numero.Next(0, 100);

            //Console.WriteLine("El numero aleatorio es " + numeroAleatorio);

            //while (numero1 <= numeroAleatorio || numero1 >= numeroAleatorio)
            //{
            //    int numero1 = int.Parse(Console.ReadLine());

            //    if (numero1 <= numeroAleatorio)
            //    {
            //        Console.WriteLine("El numero digitado es menor que el buscado");
            //        Console.WriteLine("Intente otra vez");
            //    }
            //    else if (numero1 >= numeroAleatorio)
            //    {
            //        Console.WriteLine("El numero digitado es mayor al buscado");
            //        Console.WriteLine("Intente otra vez");
            //    }
            //    else if (numero1 == numeroAleatorio)
            //    {
            //        Console.WriteLine("El numero digitado es el correcto");
            //        Console.WriteLine("Intente otra vez");
            //    }


            //}
            #region CODIGO DE EJEMPLO
            //Random numero = new Random();

            //int aleatorio = numero.Next(0, 100);
            //Console.WriteLine(aleatorio);   

            //int minumero = 101;

            //int intentos = 0;

            //Console.WriteLine("Introduce un numero entre 0 y 100");

            //while (aleatorio!= minumero)
            //{
            //    intentos++;

            //    minumero = int.Parse(Console.ReadLine());

            //    if (minumero > aleatorio) Console.WriteLine("El numero es maa bajo");

            //    if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            //}

            //Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            #endregion




            #endregion

            #region BUCLE DO-WHILE

            //int a = 10;

            //while (a < 10)
            //{
            //    Console.WriteLine("Impresion " + a );   
            //    a++;
            //}

            //int z = 10;

            //do
            //{

            //    Console.WriteLine("Impresion " + z);
            //    z++;
            //} while (z < 10);

            //******************************************************************************************************
            
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);
            Console.WriteLine(aleatorio);

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");


            do
            {
                intentos++;

                minumero = int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            } while (aleatorio != minumero);

                Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");



            #endregion

        }
    }
}
