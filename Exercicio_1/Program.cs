using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA, numB, numC, delta, raizDelta, x1, x2;

            Console.Write("A = ");
            numA = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            numB = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            numC = double.Parse(Console.ReadLine());

            delta = (numB * numB) - (4 * numA * numC);

            if (numA == 0 || delta < 0)
            {
                Console.WriteLine("Impossível calcular.");
            }

            else
            {
                raizDelta = Math.Sqrt(delta);

                x1 = (-numB + raizDelta) / (2 * numA);
                x2 = (-numB - raizDelta) / (2 * numA);

                Console.WriteLine("X1 = " + x1.ToString("F5"));
                Console.WriteLine("X2 = " + x2.ToString("F5"));
            }

        }
    }
}
