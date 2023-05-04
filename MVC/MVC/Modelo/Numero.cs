namespace MVC.Modelo
{
    internal class Numero
    {
        public string validarMayor(int NumUno, int NumDos)
        {
            if (NumUno > NumDos)
            {
                return "El numero mayor es: " + NumUno;
            }
            else if (NumUno < NumDos)
            {
                return "El numero mayor es: " + NumDos;
            }
            else
            {
                return "No puede determinarse el numero mayor.";
            }
        }

    }
}

