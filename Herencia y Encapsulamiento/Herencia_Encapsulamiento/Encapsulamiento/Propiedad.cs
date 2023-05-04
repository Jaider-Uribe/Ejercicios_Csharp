using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Encapsulamiento.Encapsulamiento
{
    internal class Propiedad
    {
        private int _valor;
        private string _direccion;
        private int _habitaciones;
        private int _plantas;
        private string _sotano;

        public int Valor { get => _valor; set => _valor = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Habitaciones { get => _habitaciones; set => _habitaciones = value; }
        public int Plantas { get => _plantas; set => _plantas = value; }
        public string Sotano { get => _sotano; set => _sotano = value; }

        public void ImprimirInformacion()
        {
            Console.WriteLine("\nEl valor de la propiedad es de: " + Valor);
            Console.WriteLine("La direccion de la propiedad es: " + Direccion);
            Console.WriteLine("El numero de habitaciones de la propiedad es de: " + Habitaciones);
            Console.WriteLine("La propiedad cuantas plantas tiene: " + Plantas);
            Console.WriteLine("La propiedad tiene sotano: " + Sotano);
        }
    }
}
