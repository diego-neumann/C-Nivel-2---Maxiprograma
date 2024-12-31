using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesafIo_1
{
    internal class Telefono
    {
        //Crear un proyecto de consola .Net Framework.
        //Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
        //Agregale los siguientes atributos:
        /*  Modelo string.
            Marca string.
            NumeroTelefonico string.
            CodigoOperador int (1, 2 o 3).*/
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        /*  Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
            Modelo: solo lectura. Es decir, solo get.
            Marca: solo lectura.
            NumeroTelefonico: lectura y escritura.
            CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
         */
        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get
            {
                return codigoOperador;
            }
            set 
            { 
                if (value == 1 || value == 2 || value == 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }
        //Agregar Constructor que reciba Modelo y Marca.
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        // Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        public string llamar()
        {
            return "Realizando llamada...";
        }
        // Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }

    }
}
