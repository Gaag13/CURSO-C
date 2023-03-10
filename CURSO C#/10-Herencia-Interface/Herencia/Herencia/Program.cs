using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            //Caballo Babieca = new Caballo("Hercules");
            //Humano Juan = new Humano();
            //Gorila Copito = new Gorila();

            //Babieca.getNombre();

            //Ballena whalle = new Ballena("Whaly");
            //whalle.nadar();

            //Console.WriteLine("Numero de patas de babieca " + Babieca.numeroPatas());

            Largatija Juancho = new Largatija("Juancho");
            Juancho.respirar();
            Juancho.getNombre();

            Humano Juan = new Humano("Juan");
            Juan.respirar();
            Juan.getNombre();
        }   
    }
    // Creando una interfaz VIDEO  48
    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }
    // Añadiendo clases abstractas https://www.youtube.com/watch?v=db110IU4i-4&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=53
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public abstract void getNombre();
    }
    class Largatija : Animales
    {
        public Largatija(string Nombre)
        {
            nombreReptil = Nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("EL nombre del reptil es : "+nombreReptil);
        }
        private string nombreReptil;    

    }
    class Mamiferos :Animales
    {
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }    
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que esten grandes");
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero: "+ nombreSerVivo);
        }               
        private string nombreSerVivo;
    }
    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        public Caballo(string Nombrecaballo) : base(Nombrecaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        public int numeroPatas()
        {
            return 4;
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
    class Adolescente : Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {

        }
    }
    class Gorila : Mamiferos,IMamiferosTerrestres
    {
        public Gorila(string NombreGorila) : base(NombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("SOy capaz de trepar");
        }
        public int numeroPatas()
        {
            return 2;
        }
    }
    // Clases selladas   https://www.youtube.com/watch?v=_SlVGK2nRJU&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=54
    class Chimpance : Gorila
    {
        public Chimpance(string nombreChimpance) : base(nombreChimpance)
        {

        }
    }

    // COMIENZO VIDEO DE INTERFAZ VIDEO 48 DE LOS VIDFEOS DE INTERFACES DE PILDORAS INFORMARICAS https://www.youtube.com/watch?v=K4JUqONrb8E&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=48
    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {
             
        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
 


