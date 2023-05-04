using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Encapsulamiento.Encapsulamiento
{
    internal class Mesa
    {
        private string _color;

        public string Color { get => _color; set => _color = value; }

        public string MostrarColor()
        {
            return "El color de la mesa es: " + Color;
        }
    }
}
