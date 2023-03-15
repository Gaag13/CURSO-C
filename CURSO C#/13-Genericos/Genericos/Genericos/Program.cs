using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    /*Problema a resolver en este codigo 14-03-2023
     * Construir una clase que sirva para cualquier tipo de objeto usando la herencia.
     * Se trata de crear una clase que sea capaz de almacenar objetos de diferente tipo
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EJEMPLO HERENCIA
            //AlmacenObjetos archivos = new AlmacenObjetos(4);
            ////archivos.agregar("Juan");
            ////archivos.agregar("Elena");
            ////archivos.agregar("Antonio");
            ////archivos.agregar("Sandra");

            ////Ver la posicion 2     1) Primer incoveniente se pretende almacenar en un string una variable tipo object por eso sale error toca hacer casting
            ////String nombrePersona = archivos.getElemento(2);

            //archivos.agregar(new Empleado(1500));
            //archivos.agregar(new Empleado(2500));
            //archivos.agregar(new Empleado(3000));
            //archivos.agregar(new Empleado(3009));

            ////String nombrePersona = (String)archivos.getElemento(3);  //Casting no es valdo hay un error almacenar en una variable tipo String un Empleado
            ////El error surge cuando el programa ya esta en ejecucion no marca ningun error antes, inconveniendo al usar herencia.
            //Empleado nombrePersona = (Empleado)archivos.getElemento(0);
            //Console.WriteLine(nombrePersona.getSalario());
            #endregion

            #region EJEMPLO GENERICOS
            //AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);

            archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra");

            //Ver la posicion 2     1) Primer incoveniente se pretende almacenar en un string una variable tipo object por eso sale error toca hacer casting
            //String nombrePersona = archivos.getElemento(2);

            //archivos.agregar(new Empleado(1500));
            //archivos.agregar(new Empleado(2500));
            //archivos.agregar(new Empleado(3000));
            //archivos.agregar(new Empleado(3009));


            String nombrePersona = archivos.getElemento(0);
            Console.WriteLine(nombrePersona);
            #endregion
        } 
    }
    #region EJEMPLO HERENCIA
    //class Empleado
    //{
    //    public Empleado(double salario)
    //    {
    //        this.salario = salario;
    //    }
    //    public double getSalario()
    //    {
    //        return salario;
    //    }
    //    private double salario;
    //}
    //class AlmacenObjetos
    //{
    //    public AlmacenObjetos(int z)      //Especificar cuantos elementos va poder almacenar el array
    //    {
    //        datosElemento = new object[z];

    //    }
    //    public void agregar(object obj)   //Metodo para agregar elementos al array
    //    {
    //        datosElemento[i] = obj;
    //        i++;
    //    }
    //    public Object getElemento(int i)  //Posicion del array para obtener la informacion de ese parametro
    //    {
    //        return datosElemento[i];
    //    }

    //    private Object[] datosElemento;   //Debe ser capaz de almacenar cualquier tipo de elemento, debido a la clase cosmica, como todo hereda de object

    //    private int i = 0;                //Contador para ir alamcenando en las diferentees posiciones elemntos 
               
    //}
    #endregion

    #region EJEMPLO GENERICOS
    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
        private double salario;
    }
    class AlmacenObjetos<T> // Creacion de genericos
    {
        public AlmacenObjetos(int z)      //Especificar cuantos elementos va poder almacenar el array
        {
            datosElemento = new T[z];

        }
        public void agregar(T obj)   //Metodo para agregar elementos al array
        {
            datosElemento[i] = obj;
            i++;
        }
        public T getElemento(int i)  //Posicion del array para obtener la informacion de ese parametro
        {
            return datosElemento[i];
        }

        private T [] datosElemento;   // se declara una clase generica

        private int i = 0;                //Contador para ir alamcenando en las diferentees posiciones elemntos 

    }
    #endregion

}
