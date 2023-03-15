using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct
{   
    enum Bonus {bajo=500, normal=1000, bueno=1500,extra=3000 };
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EJEMPLO 1.0
            //Para valores nullos se usa las siguiente sintaxis
            //Estaciones? alegia2 = null;
            //string La_alergia = alegia2.ToString();
            //Estaciones alergia = Estaciones.Invierno;
            //Console.WriteLine(La_alergia);
            #endregion

            #region EJEMPLO 2.0
            //Bonus Anntonio = Bonus.bueno;

            //double bonusAntonio = (double)Anntonio;         //casting (formato)Variable

            //double salarioAntonio = 1500 + bonusAntonio;

            //Console.WriteLine(salarioAntonio);
            #endregion

            #region EJEMPLO 3.0

            Empleado Juan = new Empleado(Bonus.bueno, 1852.36);

            Console.WriteLine("El salario del empleado es : " + Juan.getSalario());

            #endregion
        }
    }
    class Empleado
    {
        private double salario, bonus;
        public Empleado(Bonus bonusEmpleaado, double salario)
        {
            bonus = (double)bonusEmpleaado;
            this.salario = salario; 
        }
        public double getSalario()
        {
            return salario+ bonus;
        }

        
       
    }
}
