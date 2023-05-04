using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Club
    {
        public Socio _socio1;
        public Socio _socio2;
        public Socio _socio3;

        public Club(Socio socio1, Socio socio2, Socio socio3) {
            _socio1 = socio1;
            _socio2 = socio2;
            _socio3 = socio3;
        }

        public void DefinirResponsabilidad()
        {
            Socio socioAntiguo = null;
            if (_socio1.accederAntiguedad() > _socio2.accederAntiguedad() && _socio1.accederAntiguedad() > _socio3.accederAntiguedad())
            {
                socioAntiguo = _socio1;
            } else if (_socio2.accederAntiguedad() > _socio1.accederAntiguedad() && _socio2.accederAntiguedad() > _socio3.accederAntiguedad())
            {
                socioAntiguo = _socio2;
            } else if (_socio3.accederAntiguedad() > _socio1.accederAntiguedad() && _socio3.accederAntiguedad() > _socio2.accederAntiguedad()) {
                socioAntiguo = _socio3;
            }

            if (socioAntiguo != null)
            {
                Console.WriteLine("El socio con mayor antiguedad es: " + socioAntiguo.accederNombre());
            } else
            {
                Console.WriteLine("Hay varios socios con la misma antiguedad");
            }
        }
    }
}
