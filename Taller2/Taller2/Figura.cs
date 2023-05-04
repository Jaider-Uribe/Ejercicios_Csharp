using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Figura
    {
        public double _base;
        public double _altura;
        public double _lado;

        public double CalcularRectangulo()
        {
            return _base * _altura;
        }

        public double CalcularCuadrado()
        {
            return _lado * _lado;
        }
    }
}
