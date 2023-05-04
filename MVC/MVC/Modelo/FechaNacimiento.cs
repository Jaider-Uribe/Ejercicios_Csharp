namespace MVC.Modelo
{
    internal class FechaNacimiento
    {
        public string CalcularEdad(int Año)
        {
            int EdadAño = 2023 - Año;

            return "La edad del usuario es de: " + EdadAño + " años.";
        }
    }
}
