using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_metodos
{
    internal class Program
    {
        #region 1.0_METODO STATIC VOID
        //static void Main(string[] args)
        //{

        //    sumaNumeros(7, 5);
        //}

        //static void sumaNumeros(int num1, int num2)
        //{
        //    Console.WriteLine("La suma de los numeros es : " + (num1 + num2));


        //}
        #endregion

        #region 2.0_METODO int return
        //static void Main(string[] args)
        //{


        //    Console.WriteLine(sumaNumeros(7, 5));
        //}

        //static int sumaNumeros(int num1, int num2)
        //{
        //    Console.WriteLine("La suma de los numeros es : " + (num1 + num2));

        //    return num1 + num2;

        //}
        #endregion

        #region 3.0_AMBITOS Y SOBRECARGAS
        static void Main(string[] args)
        {

            Console.WriteLine(suma(7, 2.2));

        }
        static int suma(int operador1, int operador2) => operador1 + operador2;

        static double suma(int numero1, double numero2) => numero1 + numero2;

        static int suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;



        #endregion

        #region 4.0_PARAMETROS OPCIONALES
        //static void Main(string[] args)
        //{
        //    int valor1 = 7;
        //    double valor2 = 5.2;
        //    double valor3 =  8.3;

        //    Console.WriteLine(suma(valor1,valor2,valor3));
        //}

        //private static double suma(int num1, double num2, double num3=0)
        //{
        //    return num2 + num1 + num3; 
        //}
        #endregion
    }
}
