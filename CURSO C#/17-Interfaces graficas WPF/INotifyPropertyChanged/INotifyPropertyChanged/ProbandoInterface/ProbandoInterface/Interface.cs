using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoInterface
{
    public class Interface : INotifyPropertyChanged
    {
        /*El interfez INotifyPropertyChanged crea una propiedad para que cuando se realice un metodo desencadene una accion en este caso
         * El evento que se realiza es que en el recuadro de nombre y apellido se escriben los nombres por teclado y la tercera casilla entonces acumula
         * ambos parametros tanto el nombre y el apellido y desencadena un DATA Binding
        */
        private string nombre, apellido, nombre_Completo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public string Nombre
        {
           get { return nombre; }
            set { nombre = value;

                OnPropertyChanged("Nombre_completo");
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("Nombre_completo");
            }
        }      
        public string Nombre_Completo
        {
            get { nombre_Completo=Nombre + " "+ Apellido;
                return nombre_Completo; 
            }
            set { }
        }

    }
}
