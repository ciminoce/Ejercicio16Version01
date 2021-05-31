using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16Version01
{
    class Program
    {
        static void Main(string[] args)
        {
            int unNumero;
            Console.Write("Ingrese un número entero:");
            unNumero = Convert.ToInt32(Console.ReadLine());
            if (unNumero%2==0)
            {
                Console.WriteLine($"{unNumero} es par");
            }
            else
            {
                Console.WriteLine($"{unNumero} es impar");
            }

            Console.ReadLine();

        }
    }
}
