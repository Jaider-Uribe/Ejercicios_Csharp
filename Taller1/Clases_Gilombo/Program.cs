using System.Runtime.Intrinsics.X86;

namespace Taller1
{
    internal class Program
    {
        static void Main(string[] args)
        {
 /*           bool y = true;
            do {
                Console.WriteLine("- MENU -");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Parte 1");
                Console.WriteLine("2. Parte 2");
                Console.WriteLine("3. Parte 3");
                Console.WriteLine("4. Parte 4");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 0)
                {
                    y = false;

                }
                else if (opcion == 1)
                {
                    bool x = true;

                    do
                    {
                        Console.WriteLine("- EJERCICIOS PARTE 1 -");
                        Console.WriteLine("0. Salir");
                        Console.WriteLine("1. Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. Determinar cuánto pagará, con IVA incluido (19%), un cliente si la compra cumple con esta condición.");
                        Console.WriteLine("2. En un almacén se hace un 20% de descuento a los clientes cuya compra sea superior a $100.000. ¿Cuánto deberá pagar cada cliente?");
                        Console.WriteLine("3. Calcular el salario de un empleado, teniendo en cuenta que si el salario bruto es superior a $2.000.000, debe hacerse una retención del 10%.");
                        Console.WriteLine("4. Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre la cantidad que tiene en inversión en el banco. El decidirá reinvertir los intereses siempre y cuando no excedan a $7000, y en ese caso desea saber cuánto dinero tendrá finalmente en su cuenta.");

                        int ejercicio = int.Parse(Console.ReadLine());

                        if (ejercicio == 0)
                        {
                            x = false;

                        }
                        else if (ejercicio == 1)
                        {

                            Console.WriteLine("Ingrese el precio de su computadora: ");
                            double precio = double.Parse(Console.ReadLine());

                            if (precio >= 1000000)
                            {
                                double iva = precio * 0.19;
                                precio += iva;
                                double descuento = precio * 0.10;
                                precio -= descuento;
                            }
                            else
                            {
                                double iva = precio * 0.19;
                                precio += iva;
                            }

                            Console.WriteLine("Su precio a pagar es: " + precio);

                        }
                        else if (ejercicio == 2)
                        {

                            Console.WriteLine("Ingrese el precio de su compra: ");
                            double precio = double.Parse(Console.ReadLine());

                            if (precio >= 100000)
                            {
                                double descuento = precio * 0.20;
                                precio -= descuento;
                                Console.WriteLine("Su compra con el descuento del 20% es: " + precio);
                            }
                            else
                            {
                                Console.WriteLine("No tiene descuento, su compra es: " + precio);
                            }

                        }
                        else if (ejercicio == 3)
                        {

                            Console.WriteLine("Ingrese el salario bruto del empleado: ");
                            double salario = double.Parse(Console.ReadLine());

                            if (salario >= 100000)
                            {
                                double retencion = salario * 0.10;
                                salario -= retencion;
                                Console.WriteLine("Su salario tiene una retencion del 10% : " + salario);
                            }
                            else
                            {
                                Console.WriteLine("Su salario no tiene retencion. por lo que es de: " + salario);
                            }

                        }
                        else if (ejercicio == 4)
                        {

                            Console.WriteLine("Ingrese la inversion: ");
                            double inversion = double.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese los intereses: ");
                            double interes = double.Parse(Console.ReadLine());

                            double total = (inversion / 100) * interes;
                            inversion += total;
                            if (total >= 7000)
                            {
                                Console.WriteLine("En su cuenta tendra finalmente: " + inversion + ".");
                            }
                            else
                            {
                                Console.WriteLine("Su reinversion seria de : " + total + " fuera de la inversion inicial.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta.");
                        }
                    } while (x);

                }
                else if (opcion == 2)
                {
                    bool x = true;

                    do
                    {
                        Console.WriteLine("- EJERCICIOS PARTE 2 -");
                        Console.WriteLine("0. Salir");
                        Console.WriteLine("1. Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con descuento. El descuento lo hace en base a la clave, si la clave es 01 el descuento es del 10% y si la clave es 02 el descuento es del 20% (solo existen dos claves).");
                        Console.WriteLine("2. Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o más se aplica un descuento del 20% sobre el total de la compra y si son menos de tres camisas un descuento del 10%.");
                        Console.WriteLine("3. Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la distancia a recorrer y sabiendo que que esta es superior a 1.000 km, la línea aérea le hace un descuento del 30%. El precio por kilómetro es de $150.");
                        Console.WriteLine("4. Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener una persona por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica cuando el sexo es femenino, es:\r\n numpulsaciones = (220-edad)/10\r\n y si el sexo es masculino:\r\n numpulsaciones = (210-edad)/10");
                        Console.WriteLine("5. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:\r\nSi trabaja 40 horas o menos, se le paga a $10.000 la hora\r\nSi trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras 40 horas y $15.000 por cada una de las horas extras.");
                        Console.WriteLine("6. Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber cuántas calorías consume su cuerpo durante el tiempo que realice una misma actividad. Las actividades que puede realizar son únicamente dormir o estar sentado. Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando sentado en reposo consume 1.66 calorías por minuto.");
                        Console.WriteLine("7. Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica. La empresa, dependiendo del valor de la compra, decidirá la forma en que le pagará al fabricante. Si el valor de la compra excede o es igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el resto lo pagará solicitando un crédito al fabricante. Si el monto total de la compra no excede de $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando un crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.\r\n");
                        Console.WriteLine("8. Elaborar un algoritmo que permita calcular el valor total a pagar en una papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán $2.000 por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por cada uno.\r\n");
                        Console.WriteLine("9. Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones:\r\nSi los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial será del 15% del valor de la vivienda y el resto, se distribuirá en 120 cuotas mensuales con un interés del 2% mensual.\r\nSi los ingresos del comprador son inferiores a $1.200.000, la cuota inicial será del 30% del valor de la vivienda y el resto, lo distribuirá en 84 cuotas mensuales con un interés del 1% mensual. La constructora desea saber cuánto debe pagar un comprador por concepto de cuota inicial y cuánto por cada cuota mensual.");
                        Console.WriteLine("10. En un almacén se hace un 17% de descuento a los clientes cuya compra sea superior a $200.000, para las compras inferiores, el descuento será del 5%. ¿Cuánto deberá pagar cada cliente?");

                        int ejercicio = int.Parse(Console.ReadLine());

                        if (ejercicio == 0)
                        {
                            x = false;
                        }
                        else if (ejercicio == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del producto: ");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese la clave (1 ó 2): ");
                            int clave = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el precio: ");
                            double precio = double.Parse(Console.ReadLine());

                            if (clave == 1)
                            {
                                double descuento = precio * 0.10;
                                double total = precio + descuento;

                                Console.WriteLine("El nombre del producto es: " + nombre);
                                Console.WriteLine("La clave del producto es: " + clave);
                                Console.WriteLine("El precio inicial del producto es: " + precio);
                                Console.WriteLine("El descuento del producto es: " + descuento);
                                Console.WriteLine("El precio final del producto es: " + total);
                            }
                            else if (clave == 2)
                            {
                                double descuento = precio * 0.20;
                                double total = precio + descuento;

                                Console.WriteLine("El nombre del producto es: " + nombre);
                                Console.WriteLine("La clave del producto es: " + clave);
                                Console.WriteLine("El precio inicial del producto es: " + precio);
                                Console.WriteLine("El descuento del producto es: " + descuento);
                                Console.WriteLine("El precio final del producto es: " + total);
                            }
                            else
                            {
                                Console.WriteLine("Clave ingresada incorrecta");
                            }
                        }
                        else if (ejercicio == 2)
                        {
                            Console.WriteLine("Ingrese la cantidad de camisas: : ");
                            int cantidad = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio: ");
                            double precio = double.Parse(Console.ReadLine());

                            if (cantidad >= 3)
                            {
                                double descuento = precio * 0.20;
                                double total = precio + descuento;
                                Console.WriteLine("El precio individual de las camisas es: " + precio);
                                Console.WriteLine("El descuento de las camisas es: " + descuento);
                                Console.WriteLine("El precio final de las camisas es: " + total);
                            }
                            else
                            {
                                double descuento = precio * 0.10;
                                double total = precio + descuento;
                                Console.WriteLine("El precio individual de las camisas es: " + precio);
                                Console.WriteLine("El descuento de las camisas es: " + descuento);
                                Console.WriteLine("El precio final de las camisas es: " + total);
                            }
                        }
                        else if (ejercicio == 3)
                        {
                            Console.WriteLine("Ingresa la distancia a recorrer (Kilometros): ");
                            double distancia = double.Parse(Console.ReadLine());

                            double pasaje = distancia * 150;

                            if (distancia >= 1000)
                            {
                                double descuento = pasaje * 0.30;
                                double total = pasaje - descuento;
                                Console.WriteLine("El precio total de su pasaje es " + total + " con el descuento del 30%.");
                            }
                            else
                            {
                                Console.WriteLine("Su pasaje no tiene descuento, el total a pagar es: " + pasaje);
                            }
                        }
                        else if (ejercicio == 4)
                        {
                            Console.WriteLine("Ingrese su sexo (F ó M): ");
                            string sexo = Console.ReadLine();

                            Console.WriteLine("Ingrese su edad: ");
                            int edad = int.Parse(Console.ReadLine());

                            if (sexo == "F")
                            {
                                int numpulsaciones = (220 - edad) / 10;
                                Console.WriteLine("El numero de pulsaciones corresponde a: " + numpulsaciones);
                            }
                            else if (sexo == "M")
                            {
                                int numpulsaciones = (210 - edad) / 10;
                                Console.WriteLine("El numero de pulsaciones corresponde a: " + numpulsaciones);
                            }
                            else
                            {
                                Console.WriteLine("Sexo erroneo.");
                            }
                        }
                        else if (ejercicio == 5)
                        {
                            Console.WriteLine("Ingrese horas trabajadas: ");
                            int horas = int.Parse(Console.ReadLine());

                            if (horas >= 40)
                            {
                                int precioNormales = 40 * 10000;
                                int extras = horas - 40;
                                int precioExtras = extras * 15000;
                                int total = precioExtras + precioNormales;
                                Console.WriteLine("Su salario semanal con extras es: " + total);
                            }
                            else
                            {
                                int total = horas * 10000;
                                Console.WriteLine("Su salario semanal es: " + total);
                            }
                        }
                        else if (ejercicio == 6)
                        {
                            Console.WriteLine("Ingrese la actividad realizada (dormir ó sentarse): ");
                            string actividad = Console.ReadLine();

                            Console.WriteLine("Ingrese el tiempo en minutos que realizo la actividad: ");
                            int minutos = int.Parse(Console.ReadLine());

                            if (actividad == "dormir")
                            {
                                double calorias = minutos * 1.08;
                                Console.WriteLine("Dormido la persona consume " + calorias + " calorias.");
                            }
                            else if (actividad == "sentarse")
                            {
                                double calorias = minutos * 1.66;
                                Console.WriteLine("Sentado la persona consume " + calorias + " calorias.");
                            }
                            else
                            {
                                Console.WriteLine("Actividad erronea.");
                            }
                        }
                        else if (ejercicio == 7)
                        {
                            Console.WriteLine("Valor de la compra: ");
                            double valor = double.Parse(Console.ReadLine());

                            if (valor >= 5000000)
                            {
                                double propios = valor * 0.55;
                                double banco = valor * 0.30;
                                double credito = valor * 0.15;
                                double interes = credito * 0.15;
                                double total = credito + interes;
                                Console.WriteLine("En recursos propios la empresa debe pagar " + propios);
                                Console.WriteLine("En prestamo al banco la empresa debe pagar " + banco);
                                Console.WriteLine("Y se solicita un credito para pagar " + total);
                            }
                            else
                            {
                                double propios = valor * 0.70;
                                double credito = valor * 0.30;
                                double interes = credito * 0.15;
                                double total = credito + interes;
                                Console.WriteLine("En recursos propios la empresa debe pagar " + propios);
                                Console.WriteLine("Y se solicita un credito para pagar " + total);
                            }

                        }
                        else if (ejercicio == 8)
                        {
                            Console.WriteLine("Ingrese la cantidad de cuadernos a llevar");
                            int cuadernos = int.Parse(Console.ReadLine());

                            if (cuadernos >= 5)
                            {
                                int total = cuadernos * 2000;
                                Console.WriteLine("El total de su compra es: " + total);
                            }
                            else
                            {
                                int total = cuadernos * 2500;
                                Console.WriteLine("El total de su compre es: " + total);
                            }
                        }
                        else if (ejercicio == 9)
                        {
                            Console.WriteLine("Ingresos del comprador: ");
                            double ingresos = double.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el valor de la vivienda: ");
                            double vivienda = double.Parse(Console.ReadLine());

                            if (ingresos >= 1200000)
                            {
                                double cuotaInicial = vivienda * 0.15;
                                double cuotas = ((vivienda - cuotaInicial) / 120) * 0.02;
                                Console.WriteLine("La cuota inicial es: " + cuotaInicial);
                                Console.WriteLine("La cuota de los otros 120 meses es de " + cuotas + " con el 2% de interes al mes.");
                            }
                            else
                            {
                                double cuotaInicial = vivienda * 0.30;
                                double cuotas = ((vivienda - cuotaInicial) / 84) * 0.01;
                                Console.WriteLine("La cuota inicial es: " + cuotaInicial);
                                Console.WriteLine("La cuota de los otros 84 meses es de " + cuotas + " con el 1% de interes al mes.");
                            }
                        }
                        else if (ejercicio == 10)
                        {
                            Console.WriteLine("Ingrese valor de la compra: ");
                            double valor = int.Parse(Console.ReadLine());

                            if (valor >= 200000)
                            {
                                double descuento = valor * 0.17;
                                double total = valor - descuento;
                                Console.WriteLine("Su compra tiene un descuento del 17% y el valor a pagar es: " + total);
                            }
                            else
                            {
                                double descuento = valor * 0.05;
                                double total = valor - descuento;
                                Console.WriteLine("Su compra tiene un descuento del 5% y el valor a pagar es: " + total);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta.");
                        }
                    } while (x);

                }
                else if (opcion == 3)
                {
                    bool x = true;

                    do
                    {
                        Console.WriteLine("- EJERCICIOS PARTE 1 -");
                        Console.WriteLine("0. Salir");
                        Console.WriteLine("1. ");
                        Console.WriteLine("2. ");
                        Console.WriteLine("3. ");
                        Console.WriteLine("4. ");

                        int ejercicio = int.Parse(Console.ReadLine());

                        if (ejercicio == 0)
                        {
                            x = false;

                        }
                        else if (ejercicio == 1)
                        {

                        }
                        else if (ejercicio == 2)
                        {

                        }
                        else if (ejercicio == 3)
                        {

                        }
                        else if (ejercicio == 4)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta.");
                        }
                    } while (x);
                }
                else if (opcion == 4)
                {
                    bool x = true;

                    do
                    {
                        Console.WriteLine("- EJERCICIOS PARTE 1 -");
                        Console.WriteLine("0. Salir");
                        Console.WriteLine("1. ");
                        Console.WriteLine("2. ");
                        Console.WriteLine("3. ");
                        Console.WriteLine("4. ");

                        int ejercicio = int.Parse(Console.ReadLine());

                        if (ejercicio == 0)
                        {
                            x = false;

                        }
                        else if (ejercicio == 1)
                        {

                        }
                        else if (ejercicio == 2)
                        {

                        }
                        else if (ejercicio == 3)
                        {

                        }
                        else if (ejercicio == 4)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Opcion incorrecta.");
                        }
                    } while (x);
                }
            } while (y);

*/

            /*-------------------------//-----------------------------------//-------------------------------//----------------------------*/
            // PARTE 3 - CICLO REPETIDOS Y METODOS


            /*Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.*/


            /*Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.*/


            /*Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56 mostrar: cincuenta y seis. Pista: separar las unidades y las decenas. (unidades = num % 10; decenas = num / 10).*/


            /*Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.*/


            /*-------------------------//-----------------------------------//-------------------------------//----------------------------*/
            // PARTE 4 - SWITCH Y FOR (Simples y Unidados).


            /*Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.*/


            /*Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.*/


            /*Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56 mostrar: cincuenta y seis. Pista: separar las unidades y las decenas. (unidades = num % 10; decenas = num / 10).*/


            /*Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.*/


        }
    }
}


