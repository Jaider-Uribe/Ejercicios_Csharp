using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Encapsulamiento.Encapsulamiento
{
    internal class Persona
    {
        private string _nombre; 
        private int _fechaNacimiento;
        private int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public int Edad { get => _edad; set => _edad = value; }

        public string CalcularEdad()
        {
            Edad = DateTime.Today.Year - FechaNacimiento;

            return "La edad de " + Nombre + " es de: " + Edad + " años.";
        }
    }
}
