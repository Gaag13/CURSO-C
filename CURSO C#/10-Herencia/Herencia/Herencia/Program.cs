using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Caballo Babieca = new Caballo("Hercules");
            //Humano Juan = new Humano();
            //Gorila Copito = new Gorila();

            Babieca.getNombre();

            
        }   
    }
    class Mamiferos
    {
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }   
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que esten grandes");
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: "+ nombreSerVivo);
        }
        private string nombreSerVivo;
    }
    class Caballo : Mamiferos
    {
        public Caballo(string Nombrecaballo) : base(Nombrecaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    class Humano : Mamiferos
    {
        public Humano(String NombreHumano) : base(NombreHumano)
        {

        }

        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
    class Gorila : Mamiferos
    {
        public Gorila(string NombreGorila) : base(NombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("SOy capaz de trepar");
        }
    }
}
 


