using Taller2;

bool y = true;

do
{
    Console.WriteLine("- MENU -");
    Console.WriteLine("0. Salir");
    Console.WriteLine("1. Primer punto");
    Console.WriteLine("2. Segundo punto");
    Console.WriteLine("3. Tercer punto");
    Console.WriteLine("4. Cuarto punto");
    Console.WriteLine("5. Quinto punto");

    int opcion = int.Parse(Console.ReadLine());

    if (opcion == 0)
    {

        y = false;

    }
    else if (opcion == 1)
    {

        Figura rectangulo = new Figura();
        Figura cuadrado = new Figura();

        Console.WriteLine("Ingrese la base del rectangulo: ");
        rectangulo._base = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectangulo: ");
        rectangulo._altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el lado del cuadrado: ");
        cuadrado._lado = double.Parse(Console.ReadLine());

        double areaCuadrado = cuadrado.CalcularCuadrado();
        double areaRectangulo = rectangulo.CalcularRectangulo();

        Console.WriteLine("El area del cuadrado es: " + areaCuadrado);
        Console.WriteLine("El area del rectangulo es: " + areaRectangulo + "\n");
    }
    else if (opcion == 2)
    {
        List<Persona> listaPersonas = new List<Persona>();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Persona personita = new Persona(nombre);

            listaPersonas.Add(personita);
        }

        foreach (Persona personita in listaPersonas)
        {
            Console.WriteLine(personita.ToString());
        }

    }
    else if (opcion == 3)
    {
        Banco bancoSupremo = new Banco();
        Console.WriteLine(bancoSupremo._saldoBanco);

        ClienteBanco cliente1 = new ClienteBanco(bancoSupremo, "Jose");
        ClienteBanco cliente2 = new ClienteBanco(bancoSupremo, "Maria");
        ClienteBanco cliente3 = new ClienteBanco(bancoSupremo, "Jesus");

        Console.WriteLine(bancoSupremo.ObtenerDineroTotal());
        Console.WriteLine(cliente1._saldoCliente);
        Console.WriteLine(cliente2._saldoCliente);
        Console.WriteLine(cliente3._saldoCliente);        

        cliente1.Depositar(200);
        cliente2.Depositar(500);
        cliente3.Depositar(800);

        Console.WriteLine(bancoSupremo.ObtenerDineroTotal());
        Console.WriteLine(cliente1._saldoCliente);
        Console.WriteLine(cliente2._saldoCliente);
        Console.WriteLine(cliente3._saldoCliente);

        cliente1.Retirar(400);
        cliente2.Retirar(200);
        cliente3.Retirar(300);

        Console.WriteLine(bancoSupremo.ObtenerDineroTotal());
        Console.WriteLine(cliente1._saldoCliente);
        Console.WriteLine(cliente2._saldoCliente);
        Console.WriteLine(cliente3._saldoCliente);

    }
    else if (opcion == 4)
    {
        Console.WriteLine("Jugar a los Dados, ¿Listo para jugar? S/N: ");
        string decision = Console.ReadLine();

        if (decision.Equals("S"))
        {
            Dado dado = new Dado();
            int dado1 = -1, dado2 = -2, dado3 = -3;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Lanzar dado " + i);
                int dadito = dado.tirarDado();
                Console.WriteLine(dadito);
                switch (i) {
                    case 1:
                        dado1 = dadito;
                        break;
                    case 2:
                        dado2 = dadito;
                        break;
                    case 3:
                        dado3 = dadito;
                        break;
                }
            }

            if (dado1 == dado2 && dado2 == dado3)
            {
                Console.WriteLine("Ganaste!");
            } else
            {
                Console.WriteLine("Perdiste!");
            }
        }
    }
    else if (opcion == 5)
    {
        Socio socio1 = new Socio("Lucas", 2);
        Socio socio2 = new Socio("Lucia", 5);
        Socio socio3 = new Socio("Lucius", 8);

        Club clubVip = new Club(socio1, socio2, socio3);
        clubVip.DefinirResponsabilidad();

    }
    else
    {
        Console.WriteLine("Error. La opción no existe.");
    }
} while (y);
