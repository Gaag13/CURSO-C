using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambda
{
    internal class Lambda
    {
        static void Main(string[] args)
        {

            Personas P1 = new Personas();
            P1.Nombre = "Juana";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Juana";
            P2.Edad = 18;

            ComparaPersonas comparaEdad = (persona1,persona2)=> persona1 == persona2;

            ComparaPersonas2 comparaNombre = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(P1.Edad,P2.Edad));

            Console.WriteLine(comparaNombre(P1.Nombre, P2.Nombre));


            #region EJEMPLO SOBRE DELEGADOS
            //// Uso del delegado

            //OperacionesMatematicas operacion = new OperacionesMatematicas(num => num*num);

            //OperacionesMatematicas2 operacion2 = new OperacionesMatematicas2((num1,num2)=> num2+num1);

            //Console.WriteLine(operacion(4));
            //Console.WriteLine(operacion2(4,5));

            ////Otro ejercicio obtener numeros pares con expresion lambda


            //Console.WriteLine("Aca comienza el segundo ejercicio");

            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            ///*foreach (int numero in numerosPares)
            //{
            //    Console.WriteLine(numero);
            //}
            //*/
            //// otra sintaxis

            //numerosPares.ForEach(numero => { Console.WriteLine(numero); Console.WriteLine("El numero par es"); });
            #endregion

        }
        #region EJEMPLO SOBRE DELEGADOS
        public delegate int OperacionesMatematicas(int numero);

      

        /*
        public static int Cuadrado(int num)
        {
            return num*num;
        }*/

        /*
        public static int Suma (int num1,int num2)
        {
            return num1 + num2;
        }
        */
        #endregion

        public delegate bool ComparaPersonas(int Edad1, int Edad2);

        public delegate bool ComparaPersonas2(string Nombre1, string Nombre2);

        class Personas
        {
            private string nombre;

            public string Nombre { get => nombre; set => nombre = value; }

            private int edad;

            public int Edad { get => edad; set => edad = value; }
        }
    }
}
 