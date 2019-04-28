using System;

namespace CalcularFiguraPlanas
{
    class Program
    {
        static void Main(string[] args)
        {


            /* --- Calculo da área do quadrado --- */
            Quadrado calQuadrado = new Quadrado();

            Console.Write("Informe o valor da base do quadrado: ");
            string b = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura do quadrado: ");
            string h = Console.ReadLine();

            double value = calQuadrado.AreaQuadrado(Convert.ToDouble(b), Convert.ToDouble(h));

            // double value = calQuadrado.AreaQuadrado(4,4);

            Console.WriteLine();

            Console.WriteLine("Valor da área do quadrado é: " + value + " m*2");

            Console.WriteLine();
            Console.WriteLine();




            /* --- Calculo da área do triângulo --- */
            Triangulo calTriangulo = new Triangulo();

            Console.Write("Informe o valor da base do triângulo: ");
            string b2 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura do triângulo: ");
            string h2 = Console.ReadLine();

            double value2 = calTriangulo.AreaTriangulo(Convert.ToDouble(b2), Convert.ToDouble(h2));

            Console.WriteLine();

            Console.WriteLine("Valor da área do triângulo é: " + value2);

            Console.WriteLine();
            Console.WriteLine();




            /* --- Calculo da área do retângulo --- */
            Retangulo calRetangulo = new Retangulo();

            Console.Write("Informe o valor da base do retângulo: ");
            string b3 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe o valor da altura do retângulo: ");
            string h3 = Console.ReadLine();

            double value3 = calRetangulo.AreaRetangulo(Convert.ToDouble(b3), Convert.ToDouble(h3));

            Console.WriteLine();

            Console.WriteLine("Valor da área do retângulo é: " + value3 + " m*2");

            Console.WriteLine();
            Console.WriteLine();




            /* --- Calculo da área do Circulo --- */
            Circulo calCirculo = new Circulo();

            Console.Write("Informe o valor do raio do circulo em metros: ");
            string r = Console.ReadLine();

            Console.WriteLine();

            double value4 = calCirculo.AreaCirculo(Convert.ToDouble(r));

            Console.WriteLine();

            Console.WriteLine("Valor da área do circulo em metros é: " + value4 + " metros aproximadamente");

            Console.WriteLine();
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
