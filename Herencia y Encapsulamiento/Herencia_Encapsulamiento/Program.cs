using Herencia_Encapsulamiento.Encapsulamiento;
using Herencia_Encapsulamiento.Herencia;

bool externo = true;
do
{
    Console.WriteLine("\nBIENVENIDO A LOS EJERCICIOS DE HERENCIA Y ENCAPSULACIÓN\n");
    Console.WriteLine("¿Que ejercicios desea ver?(Elija el numero de la opcion deseada)\n");
    Console.WriteLine("1. Herencia");
    Console.WriteLine("2. Encapsulamiento");
    Console.WriteLine("0. Salir");


    int ejercicio = int.Parse(Console.ReadLine());

    if (ejercicio == 0)
    {
        externo = false;
    }
    else if (ejercicio == 1)
    {
        bool infinito = true;
        do
        {
            Console.WriteLine("\nBIENVENIDO A LOS EJERCICIOS DE HERENCIA\n");
            Console.WriteLine("1. Calcular area de un rectangulo o de un circulo");
            Console.WriteLine("2. Formulario para su vehiculo");
            Console.WriteLine("3. presentarse");
            Console.WriteLine("0. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    infinito = false;

                    break;
                case 1:

                    Console.WriteLine("ingrese el nombre de la figura a la que desea calcular el area (Rectangulo, Circulo)");

                    string nombre = Console.ReadLine();

                    if (nombre == "rectangulo")
                    {
                        Rectangulo rectangulito = new Rectangulo();

                        rectangulito.AsignarNombre(nombre);

                        Console.WriteLine("Ingrese el largo del rectangulo: ");
                        rectangulito._largo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el ancho del rectangulo: ");
                        rectangulito._ancho = int.Parse(Console.ReadLine());

                        int resultado = rectangulito.CalcularArea();
                        Console.WriteLine(rectangulito.ImprimirAreaFigura(resultado));

                    }
                    else if (nombre == "circulo")
                    {
                        Circulo redondo = new Circulo();

                        redondo.AsignarNombre(nombre);

                        Console.WriteLine("Ingrese el radio del circulo: ");
                        redondo._radio = int.Parse(Console.ReadLine());

                        double resultado = redondo.CalcularArea();
                        int conversor = Convert.ToInt32(resultado);

                        Console.WriteLine(redondo.ImprimirAreaFigura(conversor));
                    }
                    else
                    {
                        Console.WriteLine("Opcion erronea o inexistente.");
                    }

                    break;
                case 2:
                    Console.WriteLine("Ingrese el vehiculo del que hara el formulario(coche o motocicleta)");

                    string vehiculo = Console.ReadLine();

                    if (vehiculo == "coche")
                    {
                        Coche coche = new Coche();

                        Console.WriteLine("Ingrese la marca del coche: ");
                        coche._marca = Console.ReadLine();

                        Console.WriteLine("Ingrese el modelo del coche: ");
                        coche._modelo = Console.ReadLine();

                        Console.WriteLine("Ingrese el año del coche: ");
                        coche._año = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese si el coche tendra capota: ");
                        coche._capota = Console.ReadLine();

                        Console.WriteLine("Ingrese la calidad del radio deseada: ");
                        coche._calidadRadioEmisora = Console.ReadLine();

                        coche.MostrarDetallesVehiculo(vehiculo);
                        coche.MostrarDetallesCoche();
                    }
                    else if (vehiculo == "motocicleta")
                    {
                        Motocicleta motocicleta = new Motocicleta();

                        Console.WriteLine("Ingrese la marca de la motocicleta: ");
                        motocicleta._marca = Console.ReadLine();

                        Console.WriteLine("Ingrese el modelo de la motocicleta: ");
                        motocicleta._modelo = Console.ReadLine();

                        Console.WriteLine("Ingrese el año de la motocicleta: ");
                        motocicleta._año = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese si la motocicleta tendra cupula: ");
                        motocicleta._cupula = Console.ReadLine();

                        Console.WriteLine("Ingrese si la motocicleta tendra sliders: ");
                        motocicleta._sliders = Console.ReadLine();

                        motocicleta.MostrarDetallesVehiculo(vehiculo);
                        motocicleta.MostrarDetallesMotocicleta();
                    }
                    else
                    {
                        Console.WriteLine("Opcion erronea o inexistente.");
                    }

                    break;
                case 3:
                    Hijo persona = new Hijo();

                    Console.WriteLine("Para presentarse ingrese los siguientes datos: ");

                    Console.WriteLine("Ingrese su nombre: ");
                    persona._nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese su edad: ");
                    persona._edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su hobby: ");
                    persona._hobby = Console.ReadLine();

                    string saludo = persona.Saludar();
                    Console.WriteLine(saludo);

                    Console.WriteLine("\nSu presentación es la siguiente: \n");

                    string presentacion = persona.Presentarse();
                    Console.WriteLine(presentacion);

                    break;
            }
        } while (infinito);
    }
    else if (ejercicio == 2)
    {
        bool infinito = true;
        do
        {
            Console.WriteLine("\nBIENVENIDO A LOS EJERCICIOS DE ENCAPSULAMIENTO\n");
            Console.WriteLine("1. Datos de la propiedad");
            Console.WriteLine("2. Obtener la edad de la persona");
            Console.WriteLine("3. Ingresar el color de la mesa");
            Console.WriteLine("0. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    infinito = false;

                    break;

                case 1:
                    Propiedad propiedad = new Propiedad();

                    Console.WriteLine("Ingrese los siguientes datos para rellenar el formulario.");

                    Console.WriteLine("Ingrese el valor de la propiedad: ");
                    propiedad.Valor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la direccion de la propiedad: ");
                    propiedad.Direccion = Console.ReadLine();

                    Console.WriteLine("Ingrese el numero de habitaciones de la propiedad: ");
                    propiedad.Habitaciones = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero de plantas: ");
                    propiedad.Plantas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese si la propiedad tiene sotano: ");
                    propiedad.Sotano = Console.ReadLine();

                    Console.WriteLine("\nVisualización del formulario terminado:");

                    propiedad.ImprimirInformacion();

                    break;

                case 2:
                    Persona personita = new Persona();

                    Console.WriteLine("Ingrese los siguientes datos para calcular su edad");

                    Console.WriteLine("Ingrese su nombre: ");
                    personita.Nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese su fecha de nacimiento(año): ");
                    personita.FechaNacimiento = int.Parse(Console.ReadLine());

                    string edad = personita.CalcularEdad();

                    Console.WriteLine(edad);

                    break;

                case 3:
                    Mesa color = new Mesa();

                    Console.WriteLine("Ingrese el color de la mesa: ");
                    color.Color = Console.ReadLine();

                    string mostrar = color.MostrarColor();

                    Console.WriteLine(mostrar);

                    break;
            }
        } while (infinito);
    } 
} while (externo);
