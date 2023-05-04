namespace MVC.Vista
{
    internal class vista
    {
        public int MostrarMenu()
        {
            Console.WriteLine("\nBienvenido a los ejercicios MVC (escribir el numero de la opcion deseada)\n");
            Console.WriteLine("1. Solicitar el nombre del usuario para dar la bienvenida.");
            Console.WriteLine("2. Solicitar dos numeros para definir cual es el mayor.");
            Console.WriteLine("3. Solicitar la fecha de nacimiento para definir la edad del usuario.");
            Console.WriteLine("0. Salir.");

            int opcion = int.Parse(Console.ReadLine());
               
            if (opcion != 0 && opcion != 1 && opcion != 2 && opcion != 3)
            {
                Console.WriteLine("Opcion erronea.\n");
                return -1;
            }

            return opcion;
        }

        public string ingresarTexto(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        public void imprimir(string mensaje) {
            Console.WriteLine(mensaje);
        }
    }
}