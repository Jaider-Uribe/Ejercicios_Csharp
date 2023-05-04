using examen1Guilombo;

int totalElectrodomesticos = 0;
int totalLavadoras = 0;
int totalTelevisores = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cual de las tres opciones desea elegir: ");
    Console.WriteLine("1. Electrodomestico.");
    Console.WriteLine("2. Lavadora.");
    Console.WriteLine("3. Television.");

    int opcion = int.Parse(Console.ReadLine());

    if  ( opcion == 1 )
    {
        
        Console.WriteLine("cual es el precio base del electrodomestico?: ");
        int precio = int.Parse(Console.ReadLine());

        Console.WriteLine("cual es el color del electrodomestico: ");
        string color = Console.ReadLine();

        Console.WriteLine("cual es el consumo energetico del electrodomestico: ");
        char consumo = char.Parse(Console.ReadLine());

        Console.WriteLine("cual es el peso del electrodomestico en kg: ");
        int peso = int.Parse(Console.ReadLine());

        Electrodomestico electrodomestico = new Electrodomestico(precio, color, consumo, peso);

        Console.WriteLine("El precio final del Electrodomestico es: ");
        Console.WriteLine(electrodomestico.precioFinal());

        totalElectrodomesticos += electrodomestico.precioFinal();
    }
    else if ( opcion == 2 )
    {
        Console.WriteLine("cual es el precio base de la lavadora: ");
        int precio = int.Parse(Console.ReadLine());

        Console.WriteLine("cual es el color de la lavadora: ");
        string color = Console.ReadLine();

        Console.WriteLine("cual es el consumo energetico de la lavadora: ");
        char consumo = char.Parse(Console.ReadLine());

        Console.WriteLine("cual es el peso de la lavadora en kg: ");
        int peso = int.Parse(Console.ReadLine());

        Console.WriteLine("cual es la carga de la lavadora: ");
        int carga = int.Parse(Console.ReadLine());

        Lavadora lavadora = new Lavadora(precio, color, consumo, peso, carga);

        Console.WriteLine("El precio final de la Lavadora es: ");
        Console.WriteLine(lavadora.precioFinal());

        totalElectrodomesticos += lavadora.precioFinal();
        totalLavadoras += lavadora.precioFinal();
    }
    else if ( opcion == 3 )
    {
        Console.WriteLine("cual es el precio base del televisor: ");
        int precio = int.Parse(Console.ReadLine());

        Console.WriteLine("cual es el color del televisor: ");
        string color = Console.ReadLine();

        Console.WriteLine("cual es el consumo energetico del televisor: ");
        char consumo = char.Parse(Console.ReadLine());

        Console.WriteLine("cual es el peso del televisor: ");
        int peso = int.Parse(Console.ReadLine());

        Console.WriteLine("de cuantas pulgadas de resolucion es el televisor: ");
        int pulgadas = int.Parse(Console.ReadLine());

        Console.WriteLine("el televisor tiene sintonizador: (S/N)");
        char sintonizadorChar = char.Parse(Console.ReadLine());

        bool sintonizadorTDT = false;
        
        if ('S'.Equals(sintonizadorChar))
        {
            sintonizadorTDT = true;
        }

        Televisor televisor = new Televisor(precio, color, consumo, peso, pulgadas, sintonizadorTDT);

        Console.WriteLine("El precio final del Televisor es: ");
        Console.WriteLine(televisor.precioFinal());

        totalElectrodomesticos += televisor.precioFinal();
        totalTelevisores += televisor.precioFinal();
    }
}

Console.WriteLine("Total de los Electrodomesticos es: ");
Console.WriteLine(totalElectrodomesticos);
Console.WriteLine("Total de las Lavadoras es: ");
Console.WriteLine(totalLavadoras);
Console.WriteLine("Total de los Televisores es: ");
Console.WriteLine(totalTelevisores);
