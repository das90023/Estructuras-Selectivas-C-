using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero_uno;
            Console.WriteLine("Ingresa el numero");
            numero_uno = double.Parse(Console.ReadLine());
            if (numero_uno == 0) 
            { 
                Console.WriteLine("su numero es 0 por ende no vale nada NADAAA "); 
            
            } 
            else {
                if (numero_uno > 0)

                {
                    Console.WriteLine("tu numero es positivo");

                }
                else
                {
                    Console.WriteLine("tu numero es negativo");
                
                }
                
            }
            Console.ReadKey();
        }
    }
}
