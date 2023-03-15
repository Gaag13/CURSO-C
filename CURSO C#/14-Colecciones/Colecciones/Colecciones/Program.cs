using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CODIGO 1.0 List<>
            //List<int> Numeros = new List<int>(); // declarar una lista

            //int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            //for (int i=0; i < 5; i++)
            //{
            //    Numeros.Add(listaNumeros[i]);
            //}

            //for (int i = 0; i < Numeros.Count; i++)
            //{
            //    Console.WriteLine(Numeros[i]);
            //}
            #endregion

            #region CODIGO 1.1

            //List<int> Numeros = new List<int>(); // declarar una lista

            //Console.WriteLine("¿Cuantos elementos quieres introducir");

            //int eleme = Int32.Parse(Console.ReadLine()); /* La funcion Parse se utiliza porque Console.ReadLine solo lee parametros tipos string, entonces se le asigna 
            //                                              * la variablea la quiero convertirla y  sele agrega Int32.Parse*/
            //Console.WriteLine("Elegiste en total " + eleme +" Elementos");
            //Console.WriteLine("Ingresa los elementos que deseas");


            //for (int i = 0;i < eleme; i++)
            //{
            //    Numeros.Add(Int32.Parse(Console.ReadLine()));   
            //}

            //Console.WriteLine("Elementos introducidos");

            //for (int i = 0; i < Numeros.Count; i++)
            //{
            //    Console.WriteLine(Numeros[i]);
            //}
            #endregion

            #region CODIGO 1.2

            //List<int> Numeros = new List<int>(); // declarar una lista

            //Console.WriteLine("INTRODUCE ELEMENTOS EN LA COLECCION (0 PARA SALIR)");

            //int elem = 1;

            //while (elem != 0)
            //{
            //    elem = Int32.Parse(Console.ReadLine());

            //    Numeros.Add(elem);
            //}
            //Numeros.RemoveAt(Numeros.Count - 1);
            //Console.WriteLine("Elementos Introducidos: ");

            //foreach (int i in Numeros)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region CODIGO 2.0 LinkedList<>

            //LinkedList<int> Numeros = new LinkedList<int>();

            //foreach (int i in new int[] { 3, 10, 50, 45, 8, 2, 0 })
            //{
            //    Numeros.AddLast(i);
            //}

            //Numeros.Remove(3);

            //LinkedListNode<int> nodoImportane = new LinkedListNode<int>(20);
            //Numeros.AddFirst(nodoImportane);

            //Mostrando numeros de la LinkedList<> Numeros
            //foreach (int i in Numeros)
            //{
            //    Console.WriteLine(i);
            //}
            //for (LinkedListNode<int> nodo = Numeros.First; nodo != null; nodo = nodo.Next)
            //{
            //    int numero = nodo.Value;
            //    Console.WriteLine(numero);
            //}

            //Console.WriteLine(Numeros.Count);
            #endregion

            #region CODIGO 3.0 Queue (Cola)

            //Queue<int> numeros = new Queue<int>();

            ////Rellenando o agregando elementos a la cola

            //foreach (int i in new int[5] { 2, 4, 8, 6, 8, }) 
            //{
            //    numeros.Enqueue(i);
            //}
            ////recorriendo la cola
            //Console.WriteLine("Recorriendo el Queue");            
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}
            ////Eliminando elementos del Queue
            //Console.WriteLine("Eliminando elementos");

            //numeros.Dequeue();
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Aplicando comando Clear");
            //numeros.Clear();
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region  STACK  4.0

            //Stack<int> numeros = new Stack<int>();

            ////Rellenando o agregando elementos STACK

            //foreach (int i in new int[5] { 2, 4, 8, 6, 79, })
            //{
            //    numeros.Push(i);
            //}
            ////recorriendo la cola
            //Console.WriteLine("Recorriendo el STACK");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}
            ////Eliminando elementos del Queue
            //Console.WriteLine("Eliminando elementos");

            //numeros.Pop();
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 5.0 Dictionary

            Dictionary<string, int> edades = new Dictionary<string, int>();  //Creacion primer diccionario

            edades.Add("Marcos",10);
            edades.Add("Luisa", 10);

            edades["Maria"] = 70; //Sintaxis usada como se rellenan array
            edades["Marias"] = 50;


            foreach (KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine("Nombre:" + persona.Key + " Edad: " + persona.Value);
            }

            //Rellenar el diccionario

            #endregion

        }
    }
} 
