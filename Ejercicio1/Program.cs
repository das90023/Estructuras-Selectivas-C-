using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Solicitar datos del empleado
            Console.Write("Nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Salario actual: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Años trabajados: ");
            int añosTrabajados = int.Parse(Console.ReadLine());

            Console.Write("Categoría (1, 2, 3): ");
            int categoria = int.Parse(Console.ReadLine());

            // Determinar porcentaje por categoría sin usar switch
            double porcentajeCategoria;
            if (categoria == 1)
            {
                porcentajeCategoria = 0.15;
            }
            else if (categoria == 2)
            {
                porcentajeCategoria = 0.10;
            }
            else if (categoria == 3)
            {
                porcentajeCategoria = 0.05;
            }
            else
            {
                Console.WriteLine("Categoría no válida.");
                return;
            }

            // Calcular incremento por categoría
            double incrementoPorCategoria = salario * porcentajeCategoria;

            // Calcular incremento por años trabajados
            double incrementoPorAños = salario * (0.05 * añosTrabajados);

            // Calcular nuevo salario
            double incrementoTotal = incrementoPorCategoria + incrementoPorAños;
            double nuevoSalario = salario + incrementoTotal;

            // Mostrar resultados
            Console.WriteLine($"\nNombre: {nombre}");
            Console.WriteLine($"Nuevo Salario para el próximo año: ${nuevoSalario:F2}");
            Console.ReadKey();
        }
    }
}

