using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> Julio = new AlmacenEmpleados<Director>(5);
            Julio.agregar(new Director(4500));
            Julio.agregar(new Director(7500));
            Julio.agregar(new Director(5500));
            Julio.agregar(new Director(5500));

            AlmacenEmpleados<Secretaria> Secretaria = new AlmacenEmpleados<Secretaria>(5);
            Secretaria.agregar(new Secretaria(2330));

            //AlmacenEmpleados<Estudiante> Estudiante = new AlmacenEmpleados<Estudiante>(5);

        }
    }
    class AlmacenEmpleados<T>where T : IParaEmpleados
    {
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }
        public void agregar (T obj)
        {
            datosEmpleado[i]= obj;
            i++;
        }
        public T getEmpleados(int i)
        {
            return datosEmpleado[i];
        }
        private int i=0;

        private T[] datosEmpleado;

    }
    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad= edad;
        }
        public double getEdad()
        {
            return edad;
        }
        private double edad;
    }
    class Director:IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Secretaria:IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        private double salario;
        public double getSalario()
        {
            return salario;
        }
    }
    class Electricista:IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        private double salario;
        public double getSalario()
        {
            return salario;
        }
    }
    interface IParaEmpleados
    {
        double getSalario(); 
    }
}
