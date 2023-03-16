using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambda
{
    internal class DelegadoPredicado
    {
        //static void Main(string[] args)
        //{
        //    #region 1.0 PRIMER EJEMPLO
        //    //List<int> ListaNumeros = new List<int>();

        //    //ListaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        //    ////Declaramos delegado predicado siguiendo sintaxis

        //    //Predicate<int> ElDelegadoPred = new Predicate<int>(DamePares);

        //    //List<int> numPares = ListaNumeros.FindAll(ElDelegadoPred);

        //    //foreach (int i in numPares)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}
        //    #endregion

        //    List<Personas> gente = new List<Personas>();

        //    Personas P1 = new Personas();
        //    P1.Nombre = "Juana";
        //    P1.Edad = 18;

        //    Personas P2 = new Personas();
        //    P2.Nombre = "Maria";
        //    P2.Edad = 14;

        //    Personas P3 = new Personas();
        //    P3.Nombre = "Marcos";
        //    P3.Edad = 28;

        //    gente.AddRange(new Personas[] { P1, P2, P3 });

        //    Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

        //    bool existe = gente.Exists(elPredicado);

        //    if (existe) Console.WriteLine("Hay personas que se llaman Juan");
        //    else Console.WriteLine("No hay nadie llamado juan");

        //    Predicate<Personas> elPredicadoEdad = new Predicate<Personas>(MayoresdeEdad);

        //    bool existeEdad = gente.Exists(elPredicadoEdad);

        //    if (existeEdad) Console.WriteLine("Hay personas mayores de Edad como por ejemplo " + P2.Nombre + " Ella tiene " + P2.Edad +" años de edad");
        //    else Console.WriteLine("No hay personas mayores de edad");


        //}
        #region 1.0 PRIMER EJEMPLO
        //static bool DamePares (int num)
        //{
        //    if (num % 2 == 0) return true;
        //    else return false;
        //}
        #endregion

        static bool ExisteJuan (Personas persona)
        {
            if (persona.Nombre == "Juan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool MayoresdeEdad(Personas persona)
        {
            if (persona.Edad>= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        class Personas
        {
            private string nombre;

            public string Nombre { get => nombre; set => nombre = value; }

            private int edad;
                      
            public int Edad { get => edad; set => edad = value; }
        }

    }

}
