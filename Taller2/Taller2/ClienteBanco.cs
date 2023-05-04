using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class ClienteBanco
    {
        public Banco _banco;
        public string _nombre;
        public int _saldoCliente { get; set; } = 0;

        public ClienteBanco(Banco banco, string nombre)
        {
            _banco = banco;
            _nombre = nombre;
        }

        public void Depositar(int dinero)
        {
            _saldoCliente += dinero;
            _banco._saldoBanco += dinero;
        }

        public void Retirar(int dinero)
        {
            if (_saldoCliente < dinero)
            {
                Console.WriteLine("Saldo del cliente es insuficiente");
            }
            else
            {
                _saldoCliente -= dinero;
                _banco._saldoBanco -= dinero;
            }
        }
    }
}
