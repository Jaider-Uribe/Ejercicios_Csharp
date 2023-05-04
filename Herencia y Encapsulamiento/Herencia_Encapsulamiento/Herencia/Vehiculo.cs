using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Encapsulamiento.Herencia
{
    internal class Vehiculo
    {
        public string _marca;
        public string _modelo;
        public int _año;
        public void MostrarDetallesVehiculo(string nombre)
        {
            if (nombre == "coche")
            {
                Console.WriteLine("La marca del " + nombre + " es: " + _marca);
                Console.WriteLine("El modelo del " + nombre + " es: " + _modelo);
                Console.WriteLine("El año del " + nombre + " es: " + _año);
            }
            else if (nombre == "motocicleta ")
            {
                Console.WriteLine("La marca de la " + nombre + " es: " + _marca);
                Console.WriteLine("El modelo de la " + nombre + " es: " + _modelo);
                Console.WriteLine("El año de la " + nombre + " es: " + _año);
            } 
        }
    }

    internal class Coche : Vehiculo
    {
        public string _capota;
        public string _calidadRadioEmisora;

        public void MostrarDetallesCoche()
        {
            Console.WriteLine("El coche tendra capota: " + _capota);
            Console.WriteLine("La calidad del radio del coche es: " + _calidadRadioEmisora);
        }
    }

    internal class Motocicleta : Vehiculo
    {
        public string _cupula;
        public string _sliders;

        public void MostrarDetallesMotocicleta()
        {
            Console.WriteLine("La motocicleta contara con cupula: " + _cupula);
            Console.WriteLine("La motocicleta contara con sliders: " + _sliders);
        }
    }
}
