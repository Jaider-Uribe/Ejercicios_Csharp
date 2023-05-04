using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Banco
    {
        public int _saldoBanco { get; set; } = 0;

        public string ObtenerDineroTotal() {
            return $"La cantidad de dinero que hay depositada es: {_saldoBanco}";
        }
    }
}
