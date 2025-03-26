using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el número base
            Console.Write("Ingrese un número real: ");
            double numero = double.Parse(Console.ReadLine());

            // Solicitar el exponente
            Console.Write("Ingrese un exponente entero (-4 a 4): ");
            int exponente = int.Parse(Console.ReadLine());

            // Validar el rango del exponente
            if (exponente < -4 || exponente > 4)
            {
                Console.WriteLine("El exponente debe estar entre -4 y 4.");
                return;
            }

            // Calcular la potencia
            double resultado = 1; // Inicia en 1 porque cualquier número elevado a 0 da 1
            if (exponente > 0)
            {
                // Calcular para exponentes positivos
                for (int i = 0; i < exponente; i++)
                {
                    resultado *= numero;
                }
            }
            else if (exponente < 0)
            {
                // Calcular para exponentes negativos
                for (int i = 0; i < -exponente; i++)
                {
                    resultado *= numero;
                }
                resultado = 1 / resultado;
            }
            // Si el exponente es 0, resultado permanece 1 (cualquier número elevado a 0 es 1)

            // Mostrar el resultado
            Console.WriteLine($"\nEl resultado de {numero} elevado a la potencia {exponente} es: {resultado}");
            Console.ReadKey();
        }
    }

}
