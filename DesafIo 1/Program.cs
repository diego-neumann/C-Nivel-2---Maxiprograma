using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafIo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono
            Telefono telefonoActual = new Telefono("S20", "Samsung");
            Telefono telefonoAnterior = new Telefono("G4", "Motorola");
            //telefonoActual.NumeroTelefonico = "3764855998";
            //telefonoAnterior.NumeroTelefonico = "3764855998";
            //telefonoActual.CodigoOperador = 1;
            //telefonoAnterior.CodigoOperador = 2;

            //Console.WriteLine("Datos del telefono actual: ");
            //Console.WriteLine("Modelo: " + telefonoActual.Modelo);
            //Console.WriteLine("Marca: " + telefonoActual.Marca);
            //Console.WriteLine("Nro. telefonico: " + telefonoActual.NumeroTelefonico);
            //Console.WriteLine("Codigo Operador: " + telefonoActual.CodigoOperador);

            //Console.WriteLine("Datos del telefono anterior: ");
            //Console.WriteLine("Modelo: " + telefonoAnterior.Modelo);
            //Console.WriteLine("Marca: " + telefonoAnterior.Marca);
            //Console.WriteLine("Nro. telefonico: " + telefonoAnterior.NumeroTelefonico);
            //Console.WriteLine("Codigo Operador: " + telefonoAnterior.CodigoOperador);

            // Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
            Console.WriteLine( telefonoActual.llamar());
            Console.WriteLine( telefonoActual.llamar("Sol"));


            Console.ReadKey();



        }
    }
}
