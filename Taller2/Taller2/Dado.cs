using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Dado
    {
        public int tirarDado() {
            Random random = new Random();
            int dado = random.Next(1, 7);
            return dado;
        }
    }
}
