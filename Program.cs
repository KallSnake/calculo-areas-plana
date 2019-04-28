using System;

namespace CalcularFiguraPlanas
{
    class Program
    {
        static void Main(string[] args)
        {

            /* --- Calculo da area do quadrado --- */
            Quadrado calQuadrado = new Quadrado();

            Console.Write("Informe o valor da base do quadrado: ");
            string b = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura do quadrado: ");
            string h = Console.ReadLine();

            double value = calQuadrado.AreaQuadrado(Convert.ToDouble(b), Convert.ToDouble(h));

            // double value = calQuadrado.AreaQuadrado(4,4);

            Console.WriteLine();

            Console.WriteLine("Valor da area do quadrado é: " + value + " m*2");

            Console.WriteLine();
            Console.WriteLine();




            /* --- Calculo da area do triangulo --- */
            Triangulo calTriangulo = new Triangulo();

            Console.Write("Informe o valor da base do triangulo: ");
            string b2 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura do triangulo: ");
            string h2 = Console.ReadLine();

            double value2 = calTriangulo.AreaTriangulo(Convert.ToDouble(b2), Convert.ToDouble(h2));

            Console.WriteLine();

            Console.WriteLine("Valor da area do triangulo é: " + value2);

            Console.WriteLine();
            Console.WriteLine();




            /* --- Calculo da area do retangulo --- */
            Retangulo calRetangulo = new Retangulo();

            Console.Write("Informe o valor da base do retangulo: ");
            string b3 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura do retangulo: ");
            string h3 = Console.ReadLine();

            double value3 = calRetangulo.AreaRetangulo(Convert.ToDouble(b3), Convert.ToDouble(h3));

            Console.WriteLine();

            Console.WriteLine("Valor da area do retangulo é: " + value3 + " m*2");

            Console.WriteLine();
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
