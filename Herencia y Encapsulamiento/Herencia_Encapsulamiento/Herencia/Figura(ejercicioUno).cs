namespace Herencia_Encapsulamiento.Herencia
{
    internal class Figura
    {
        public string _nombre;      

        public void AsignarNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public string ImprimirAreaFigura(int area)
        {
            return "El area del " + _nombre + " es: " + area;
        }
    }

    internal class Rectangulo : Figura
    {
        public int _largo;
        public int _ancho;
        public int CalcularArea()
        {
            return _largo * _ancho;
        }
    }

    internal class Circulo : Figura
    {
        public double _radio;
        public double CalcularArea()
        {
            return 3.141516 * (_radio * 2);

        }
    }

}
