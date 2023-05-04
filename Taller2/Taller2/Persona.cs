using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Persona
    {
        private string _nombre { get; set; }

        public Persona(string nombre)
        {
            _nombre = nombre;
        }

        public override string ToString()
        {
            return $"El nombre de la persona es: {_nombre}";
        }
    }
}
