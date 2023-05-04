using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1Guilombo
{
    internal class Electrodomestico
    {
        private int _precio_Base = 100;
        private string _color = "blanco";
        private char _consumo_Energetico = 'F';
        private int _peso = 5;

        public int Precio_Base { get => _precio_Base; set => _precio_Base = value; }
        public string Color { get => _color; set => _color = value; }
        public char Consumo_Energetico { get => _consumo_Energetico; set => _consumo_Energetico = value; }
        public int Peso { get => _peso; set => _peso = value; }

        public Electrodomestico() { }

        public Electrodomestico(int precio_Base, int peso)
        {
            Precio_Base = precio_Base;
            Peso = peso;
        }

        public Electrodomestico(int precio_Base, string color, char consumo_Energetico, int peso)
        {
            Precio_Base = precio_Base;
            Peso = peso;
            Console.WriteLine(comprobarConsumoEnergetico(consumo_Energetico));
            Console.WriteLine(comprobarColor(color));
        }

        private string comprobarConsumoEnergetico(char letra)
        {
            if (letra.Equals('A') || letra.Equals('B') || letra.Equals('C') || letra.Equals('D') || letra.Equals('E') || letra.Equals('F'))
            {
                Consumo_Energetico = letra;
                return "La letra es correcta.";
            }
            else
            { 
                return "La letra no es correcta, se usara la letra por defecto";
            }
        }

        private string comprobarColor(string color)
        {
            if (color == "blanco" || color == "negro" || color == "rojo" || color == "azul" || color == "gris")
            {
                Color = color;
                return "El color es correcto.";
            }
            else
            {
                return "El color es inexistente, se usara el color por defecto";
            }
        }

        public virtual int precioFinal()
        {
            char letra = Consumo_Energetico;
            int peso = Peso;
            if ('A'.Equals(letra))
            {
                Precio_Base += 100;
            } 
            else if ('B'.Equals(letra))
            {
                Precio_Base += 80;
            } 
            else if ('C'.Equals(letra))
            {
                Precio_Base += 60;
            } 
            else if ('D'.Equals(letra))
            {
                Precio_Base += 50;
            }
            else if ('E'.Equals(letra))
            {
                Precio_Base += 30;
            } 
            else if('F'.Equals(letra))
            {
                Precio_Base += 10;
            }


            if (peso >= 0 && peso <= 19)
            {
                Precio_Base += 10;
            } 
            else if (peso >= 20 && peso <= 49)
            {
                Precio_Base += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                Precio_Base += 80;
            }
            else
            {
                Precio_Base += 100;
            }

            return Precio_Base;
        }
    }




    class Lavadora : Electrodomestico
    {
        private int _carga = 5;

        public int Carga { get => _carga; set => _carga = value; }

        public Lavadora() : base() {}

        public Lavadora(int precio_Base, int peso) : base(precio_Base, peso) { }

        public Lavadora(int precio_Base, string color, char consumo_Energetico, int peso, int carga) : base (precio_Base, color, consumo_Energetico, peso)
        {
            Carga = carga;
        }

        public override int precioFinal()
        {
            if (Carga > 30)
            {
                Precio_Base += 50;  
            }
            
            return base.precioFinal();     
        }
    }



    class Televisor : Electrodomestico {

        private int _pulgadas = 20;
        private bool _sintonizadorTDT = false;

        public int Pulgadas { get => _pulgadas; set => _pulgadas = value; }
        public bool SintonizadorTDT { get => _sintonizadorTDT; set => _sintonizadorTDT = value; }

        public Televisor() : base() {}

        public Televisor(int precio_Base, int peso) : base(precio_Base, peso) { }

        public Televisor(int precio_Base, string color, char consumo_Energetico, int peso, int pulgadas, bool sintonizadorTDT) : base (precio_Base, color, consumo_Energetico, peso)
        {
            Pulgadas = pulgadas;
            SintonizadorTDT = sintonizadorTDT;
        }

        public override int precioFinal()
        {
            if (Pulgadas > 40)
            {
                double porcentaje = Precio_Base * 0.3;
                int recibir = (int) porcentaje;

                Precio_Base += recibir;
            }

            if (SintonizadorTDT)
            {
                Precio_Base += 50;
            }

            return base.precioFinal();
        }


    }

        


}
