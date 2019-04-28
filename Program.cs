using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFiguraPlanas
{
    class Program
    {
        static void Main(string[] args)
        {

            /* --- Calculo da area do quadrado --- */
            Quadrado calQuadrado = new Quadrado();

            Console.Write("Informe o valor da base: ");
            string b = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura: ");
            string h = Console.ReadLine();

            double value = calQuadrado.AreaQuadrado(Convert.ToDouble(b), Convert.ToDouble(h));

            // double value = calQuadrado.AreaQuadrado(4,4);

            Console.WriteLine();

            Console.WriteLine("Valor da area do quadrado é: " + value);

            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
