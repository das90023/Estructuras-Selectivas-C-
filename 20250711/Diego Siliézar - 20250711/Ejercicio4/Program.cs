using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Solicitar un número al usuario
            Console.Write("Ingrese un número (entero o real): ");
            double numero = double.Parse(Console.ReadLine());

            // Calcular el valor absoluto
            double valorAbsoluto;
            if (numero < 0)
            {
                valorAbsoluto = -numero;
            }
            else
            {
                valorAbsoluto = numero;
            }

            // Mostrar el resultado
            Console.WriteLine($"El valor absoluto de {numero} es: {valorAbsoluto}");
            Console.ReadKey();
        }
    }
}

