using System;

namespace Ejercicio07
{
    internal class Program
    {
        // Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y
        // la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
        // Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de
        // multiplicar el valor hora por la cantidad de horas trabajadas), hay que
        // sumarle la cantidad de años trabajados multiplicados por $150, y al total
        // de todas esas operaciones restarle el 13% en concepto de descuentos.
        // Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
        // el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
        // IMPORTANTE: Utilizar sentencias de iteración y selectivas. No es necesario ni se deben utilizar vectores/arrays.
        static void Main(string[] args)
        {
            decimal valorHora;
            string valorHoraString;
            bool valorHoraValidar;
            string nombre;
            int antiguedad;
            string antiguedadString;
            bool antiguedadValidar;
            decimal cantidadHorasTrabajadas;
            string cantidadHorasTrabajadasString;
            bool cantidadHorasTrabajadasValidar; ;
            int cantidadEmpleados;
            string cantidadEmpleadosString;
            bool cantidadEmpleadosValidar;

            decimal importeSinAntiguedad;
            decimal importeAntiguedad;
            decimal importeConAntiguedad;
            const decimal descuentos = 0.13M;
            decimal importeConDescuentos;

            Console.WriteLine("Cuantos empleados son?");
            cantidadEmpleadosString = Console.ReadLine();
            cantidadEmpleadosValidar = int.TryParse(cantidadEmpleadosString, out cantidadEmpleados);
            while (!cantidadEmpleadosValidar || cantidadEmpleados < 1)
            {
                Console.WriteLine("**ERROR** Ingrese un valor de hora trabajada valido:");
                cantidadEmpleadosString = Console.ReadLine();
                cantidadEmpleadosValidar = int.TryParse(cantidadEmpleadosString, out cantidadEmpleados);
            }
            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("Ingrese el valor de la hora trabajada:");
                valorHoraString = Console.ReadLine();
                valorHoraValidar = Decimal.TryParse(valorHoraString, out valorHora);
                while (!valorHoraValidar || valorHora < 1)
                {
                    Console.WriteLine("**ERROR** Ingrese un valor de hora trabajada valido:");
                    valorHoraString = Console.ReadLine();
                    valorHoraValidar = Decimal.TryParse(valorHoraString, out valorHora);
                }

                Console.WriteLine("Ingrese el nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad:");
                antiguedadString = Console.ReadLine();
                antiguedadValidar = int.TryParse(antiguedadString, out antiguedad);
                while (!antiguedadValidar || antiguedad < 1)
                {
                    Console.WriteLine("**ERROR** Ingrese una antiguedad valida:");
                    antiguedadString = Console.ReadLine();
                    antiguedadValidar = int.TryParse(antiguedadString, out antiguedad);
                }

                Console.WriteLine("Cuantas horas trabajo en el ultimo mes:");
                cantidadHorasTrabajadasString = Console.ReadLine();
                cantidadHorasTrabajadasValidar = Decimal.TryParse(cantidadHorasTrabajadasString, out cantidadHorasTrabajadas);
                while (!cantidadHorasTrabajadasValidar || cantidadHorasTrabajadas < 1)
                {
                    Console.WriteLine("**ERROR** Ingrese una antiguedad valida:");
                    cantidadHorasTrabajadasString = Console.ReadLine();
                    cantidadHorasTrabajadasValidar = Decimal.TryParse(cantidadHorasTrabajadasString, out cantidadHorasTrabajadas);
                }

                importeSinAntiguedad = valorHora * cantidadHorasTrabajadas;
                importeAntiguedad = antiguedad * 150;
                importeConAntiguedad = importeSinAntiguedad + importeAntiguedad;
                importeConDescuentos = importeConAntiguedad - (importeConAntiguedad * descuentos);

                Console.WriteLine($"El empleado {nombre}, este mes cobra ${importeConDescuentos}");

            }


        }
    }
}
