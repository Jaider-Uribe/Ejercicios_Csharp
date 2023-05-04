using MVC.Vista;
using MVC.Modelo;

vista vistaConsola = new vista();

bool satoru = true;
do
{
    int opcion = vistaConsola.MostrarMenu();

    if (opcion == 0)
    {
        satoru = false;
    }
    else if (opcion == 1)
    {
        Persona usuario = new Persona();

        usuario._nombre = vistaConsola.ingresarTexto("Ingrese su nombre: ");

        string saludo = usuario.Saludar();

        vistaConsola.imprimir(saludo);
    }
    else if (opcion == 2)
    {
        Numero operacion = new Numero();

        int NumUno = int.Parse(vistaConsola.ingresarTexto("Ingrese el primer numero: "));

        int NumDos = int.Parse(vistaConsola.ingresarTexto("Ingrese el segundo numero: "));

        string validado = operacion.validarMayor(NumUno, NumDos);

        vistaConsola.imprimir(validado);

    }
    else if (opcion == 3)
    {
        FechaNacimiento Edad = new FechaNacimiento();

        int Año = int.Parse(vistaConsola.ingresarTexto("Ingrese el año en el que nacio: "));

        string mensaje = Edad.CalcularEdad(Año);

        vistaConsola.imprimir(mensaje);
    }

} while (satoru);