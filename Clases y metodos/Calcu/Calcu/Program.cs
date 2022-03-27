using System;
using LogicaCalculadora;

namespace Calcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char seguir = 's';
            char salir;
            decimal operandoA = 0;
            string operandoAString;
            bool operandoAValidar;
            int flagOperandoA = 0;
            decimal operandoB = 0;
            string operandoBString;
            bool operandoBValidar;
            int flagOperandoB = 0;
            char operacion = 'x';
            string operacionString;
            int flagOperacion = 0;
            decimal resultado;

            do
            {
                switch (Menu(operandoA, flagOperandoA, operandoB, flagOperandoB, operacion, flagOperacion))
                {
                    case 1:
                        Console.Write("Ingrese un numero: ");
                        operandoAString = Console.ReadLine();
                        operandoAValidar = Decimal.TryParse(operandoAString, out operandoA);
                        while (!operandoAValidar)
                        {
                            Console.Write("**ERROR** Ingrese un numero valido: ");
                            operandoAString = Console.ReadLine();
                            operandoAValidar = Decimal.TryParse(operandoAString, out operandoA);
                        }
                        flagOperandoA = 1;
                        break;
                    case 2:
                        Console.Write("Ingrese un numero: ");
                        operandoBString = Console.ReadLine();
                        operandoBValidar = Decimal.TryParse(operandoBString, out operandoB);
                        while (!operandoBValidar)
                        {
                            Console.Write("**ERROR** Ingrese un numero valido: ");
                            operandoBString = Console.ReadLine();
                            operandoBValidar = Decimal.TryParse(operandoBString, out operandoB);
                        }
                        flagOperandoB = 1;
                        break;
                    case 3:
                        Console.Write("Ingrese una operacion: ( +, -, * ó / ): ");
                        operacionString = Console.ReadLine();
                        operacion = char.Parse(operacionString);
                        while (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
                        {
                            Console.Write("**ERROR** Ingrese una operacion valida ( +, -, * ó / ): ");
                            operacionString = Console.ReadLine();
                            operacion = char.Parse(operacionString);
                        }
                        flagOperacion = 1;
                        break;
                    case 4:
                        resultado = Calculadora.Calcular(operandoA, operandoB, operacion);
                        Console.Write($"El resultado es: {resultado}");

                        break;
                    case 5:
                        Console.WriteLine("Esta seguro que desea salir? (s/n)");
                        salir = char.Parse(Console.ReadLine());
                        if (salir == 's')
                        {
                            seguir = 'n';
                        }
                        else
                        {
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
                Console.ReadKey();
            } while (seguir == 's');


        }
        public static int Menu(decimal operandoA, int flagOperandoA, decimal operandoB, int flagOperandoB, char operacion, int flagOperacion)
        {
            int opcion = 0;
            string opcionTexto;
            bool opcionValidar = false;
            Console.Clear();
            Console.WriteLine("  CALCULADORA  ");
            if (flagOperandoA == 0)
            {
                Console.WriteLine("1 - Ingrese primer operando (A = X)");
            }
            else
            {
                Console.WriteLine($"1 - Ingrese primer operando (A = {operandoA})");
            }
            if (flagOperandoB == 0)
            {
                Console.WriteLine("2 - Ingrese segundo operando (B = Y)");
            }
            else
            {
                Console.WriteLine($"2 - Ingrese segundo operando (B = {operandoB})");
            }
            if (flagOperacion == 0)
            {
                Console.WriteLine("3 - Ingrese la operacion a realizar ( +, -, * ó / )");
            }
            else
            {
                Console.WriteLine($"3 - Ingrese la operacion a realizar ( {operacion} )");
            }
            Console.WriteLine("4 - Calcular");
            Console.WriteLine("5 - Salir");
            Console.Write("Ingrese opcion: ");
            opcionTexto = Console.ReadLine();
            opcionValidar = int.TryParse(opcionTexto, out opcion);
            while (!opcionValidar)
            {
                Console.WriteLine("**ERROR** Ingrese un numero valido: ");
                opcionTexto = Console.ReadLine();
                opcionValidar = int.TryParse(opcionTexto, out opcion);
            }
            return opcion;
        }
    }
}
