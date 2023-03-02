using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EXCEPCIONES I Y II
            //Random numero = new Random();

            //int aleatorio = numero.Next(0, 100);
            //Console.WriteLine(aleatorio);

            //int minumero;

            //int intentos = 0;

            //Console.WriteLine("Introduce un numero entre 0 y 100");

            //do
            //{
            //    intentos++;

            //    try
            //    {
            //        minumero = int.Parse(Console.ReadLine());
            //    }
            //    catch(Exception e)
            //    {
            //        Console.WriteLine("No has introducido un valor numerico valido. Se toma como numero introducido el 0 ");
            //        Console.WriteLine(e.Message);
            //        minumero = 0;
            //    }

            //    if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

            //    if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            //} while (aleatorio != minumero);

            //    Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            //Console.WriteLine(" A partir de esta linea el codigo del programa continuaria");
            #endregion

            #region CAPTURA CON FILTROS

            //Random numero = new Random();

            //int aleatorio = numero.Next(0, 100);
            //Console.WriteLine(aleatorio);

            //int minumero;

            //int intentos = 0;

            //Console.WriteLine("Introduce un numero entre 0 y 100");

            //do
            //{
            //    intentos++;

            //    try
            //    {
            //        minumero = int.Parse(Console.ReadLine());
            //    }
            //    catch (Exception e) when (e.GetType()!=typeof(FormatException))
            //    {
            //        Console.WriteLine("No has introducido un valor numerico valido. Se toma como numero introducido el 0 ");
            //        //Console.WriteLine(e.Message);
            //        minumero = 0;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Has introducido texto");
            //        minumero = 0;
            //    }



            //    if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

            //    if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            //} while (aleatorio != minumero);

            //Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            //Console.WriteLine(" A partir de esta linea el codigo del programa continuaria");



            #endregion

            #region EXCEPCIONES BLOQUE FINALLY

            System.IO.StreamReader archivo = null;                                                   // leyendo archivo de texto

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\User\Desktop\CURSO C#\5-Excepciones\HOLA MUNDO.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Eror con la lectura del archivo");
            }
            finally
            {
                if(archivo != null) archivo.Close();

                Console.WriteLine("Conexion con el fichero cerrada ");
            }

            #endregion


        }
    }
}
