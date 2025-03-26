using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la temperatura en Fahrenheit
            Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // Convertir a grados Centígrados
            double celsius = (fahrenheit - 32) * 5 / 9;

            // Determinar color y mensaje según el rango de temperatura en grados Centígrados
            string color;
            string mensaje;

            if (celsius < 0)
            {
                color = "Azul";
                mensaje = "Muy frío";
            }
            else if (celsius >= 0 && celsius <= 15)
            {
                color = "Celeste";
                mensaje = "Frío";
            }
            else if (celsius > 15 && celsius <= 25)
            {
                color = "Verde";
                mensaje = "Templado";
            }
            else if (celsius > 25 && celsius <= 35)
            {
                color = "Amarillo";
                mensaje = "Cálido";
            }
            else
            {
                color = "Rojo";
                mensaje = "Muy caliente";
            }

            // Mostrar resultados
            Console.WriteLine($"\nTemperatura en grados Centígrados: {celsius:F2}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Mensaje: {mensaje}");
            Console.ReadKey();
        }
    }
}
