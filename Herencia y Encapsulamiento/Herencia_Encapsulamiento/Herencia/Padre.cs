namespace Herencia_Encapsulamiento.Herencia
{
    internal class Padre
    {

        public string _nombre;
        public int _edad;

        public string Saludar()
        {
            return "\nHola " + _nombre + " de " + _edad + " años.";
        }
    }

    internal class Hijo : Padre {
        public string _hobby;

        public string Presentarse()
        {
            return "Hola, soy " + _nombre + " tengo " + _edad + " años y mi hobby es: " + _hobby;
        }
    }
}
