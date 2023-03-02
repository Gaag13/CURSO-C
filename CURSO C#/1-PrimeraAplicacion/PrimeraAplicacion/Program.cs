using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.0_PRIMERA APLICACION VIENDO COMANDOS BASICOS
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Bienvenidos al curso C#");

            //}

            #endregion

            #region 2.0_SINTAXIS BASICA I
            //ESTO ES UN COMENTARIO CON LAS DOS BARRAS ES UNA FORMA DE COMENTAR
            /*SI SE NECESITAN REALIZAR COMENTARIOS DE VARIAS LINEAS
             * SE HACE ASI CON UN /* ENTONCES POR ESO ES QUE SE EJECUTA ASI
             * */
            // SE PUEDEN COMENTAR FUNCIONE METODOS CLASES Y TODO PONIENDO // ANTES DE CADA CODIGO
            #endregion

            #region 3.0_SINTAXIS BASICA II

            // VER NOTAS CUADERNO

            #endregion

            #region 4.0_SINTAXIS BASICA III

            //int edad = 20;
            //edad+=5;
            //Console.WriteLine(edad);
            //Console.WriteLine("Tienes una edad " + ++edad + " años");
            //Console.WriteLine($"Tienes una edad {edad} años");
            #endregion

            #region 5.0_ SINTAXIS BASICA IV

            //int edadPersona1;
            //int edadPersona2;
            //int edadPersona3;
            //int edadPersona4;

            //edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 30;
            //Console.WriteLine(edadPersona4);

            //double temperatura = 34.5;
            //int temperaturaMadrid;

            //Conversion explicita
            //casting

            //temperaturaMadrid = (int) temperatura;

            ////Console.WriteLine(temperaturaMadrid);

            ////Conversion explicita

            //int habitantesCiudad = 10000000;

            //long habitantesCiudad2018 = habitantesCiudad;

            //float pesoMaterial = 5.78F;

            //double pesoMaterialPrec = pesoMaterial;



            //Console.WriteLine(pesoMaterialPrec);

            #endregion

            #region 6.0_ SINTAXIS BASICA V

            //Console.WriteLine("Introduce el primer numero");
            //int num1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce el segundo numero");
            //int num2=int.Parse(Console.ReadLine());

            //Console.WriteLine("El resultado es "+ (num1*num2));

            //Console.WriteLine($"El resultado es {num1 + num2}");
            #endregion

            #region 7.0_SINTAXIS BASICA VI USO DE CONSTANTES
            //const int HOUSE = 10;
            //const int HOUSE2 = 5;

            //Console.WriteLine("EL VALOR DE LA CONSTANTE ES : " +(HOUSE+HOUSE2));
            //Console.WriteLine("El VALOR DE LA CONSTANTE ES : {0}", HOUSE,HOUSE2 );
            //Console.WriteLine("El VALOR DE LA CONSTANTE ES : {0} {1}", HOUSE, HOUSE2);
            //Console.WriteLine("El VALOR DE LA CONSTANTE ES : {0}", (HOUSE+ HOUSE2));

            //EJERCICIO CALCULAR EL AREA DE UN CIRCULO

            //const double PI = 3.1416;

            //Console.WriteLine("Introduce la medida del radio en m2" );

            //double radio = double.Parse( Console.ReadLine() );

            //double area = radio * radio * PI;

            //double area1 = Math.Pow(radio, 2)*PI;


            //Console.WriteLine($"El area del circulo es : {area} m2");
            //Console.WriteLine($"El area del circulo es : {area1} m2");
            #endregion
        }
    }
}