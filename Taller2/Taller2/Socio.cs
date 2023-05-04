using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Socio
    {
        private string _nombre { get; set; }
        private int _antiguedad { get; set; } = 0;

        public Socio(string nombre, int antiguedad)
        {
            _nombre = nombre;
            this.AsignarAntiguedad(antiguedad);
        }

        public void AsignarAntiguedad(int antiguedad)
        {
            if (antiguedad >= 0) {
                this._antiguedad = antiguedad;
            } else
            {
                Console.WriteLine("Valor invalido");
            }
        }

        public string accederNombre()
        {
            return _nombre;
        }

        public int accederAntiguedad()
        {
            return _antiguedad;
        }
    }
}

