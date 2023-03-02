using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.0_Array I
            /*
            int[] edades = new int[5];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 30;
            edades[3] = 5;
            edades[4] = 80;

            int[] edades2 = { 15, 27, 30, 5, 80 };

            
            Console.WriteLine(edades[2]);

            Console.WriteLine(edades2[3]);
            */
            #endregion

            #region 2.0_Array II

            // Array implicito
            
            var datos = new[] { "Juan", "Giancarlo", "Eliana" };

            var valores = new[] { 15, 28, 35, 75.5, 30.30 };    //Todo a double

           


            //Console.WriteLine(datos[2]) ;
            //Console.WriteLine(valores[3]);
            
            //Array de objetos

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            Empleados Ana = new Empleados("Ana", 28);
            arrayEmpleados[1] = Ana;
            Console.WriteLine(arrayEmpleados[1]);


            // Array de tipos o clases anonimas

            var personas = new[]
            {
                new{Nombre="Juan",Edad=19},

                new{Nombre="Maria",Edad=49},

                new{Nombre="Diana",Edad=16}

            };

            //Console.WriteLine(personas[1]);

            #region 3.0_Arrays III BUCLE FOR

            //for (int i=0; i<5; i++)
            //{
            //    Console.WriteLine(valores[i]);

            //}
            #endregion

            #region IV BUCLE FOREACH
            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine(valores[i]);

            //}

            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());

            }

            #endregion




        }
    }
    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;

            this.edad = edad;
        }

        public String getInfo()
        {
            return " nombre del empleado:" + nombre + " Edad:" + edad;

        }

        private String nombre;

        private int edad;
                    
    }
    #endregion

   



} 
