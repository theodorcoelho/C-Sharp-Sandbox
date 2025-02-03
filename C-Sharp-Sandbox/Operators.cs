using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Sandbox
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            int intA = 56;
            int intB = 12;
            float floatA = 155.1f;
            float floatB = 4.1542f;
            int integral = 12;
            float pontoFlutuanteFloat = 1.1f;
            double pontoFlutuanteDouble = 34.2425364326234;
            decimal pontoFlutuanteDecimal = 13.99m;

            // Variáveis para armazenar resultados
            int intSomaIntAeIntB = intA + intB;
            int intSomaFloatAeIntB = (int)(floatA + intB); //'(int)' converte para int o valor entre parenteses a direita
            int intSomaIntAeFloatB = (int)(intA + floatB);
            float floatSomaIntAeFloatB = intA + floatB;

            Console.WriteLine("Valores das variáveis básicas:");
            Console.WriteLine("Integral A: " + intA);
            Console.WriteLine("Integral B: " + intB);
            Console.WriteLine("Flutuante A: " + floatA);
            Console.WriteLine("Flutuante B: " + floatB);

            Console.WriteLine("\nValores das variáveis de diferentes precisões:");
            Console.WriteLine("Integral: " + integral);
            Console.WriteLine("Ponto Flutuante (float): " + pontoFlutuanteFloat);
            Console.WriteLine("Ponto Flutuante (double): " + pontoFlutuanteDouble);
            Console.WriteLine("Ponto Flutuante (decimal): " + pontoFlutuanteDecimal);

            Console.WriteLine("\nOperações básicas entre inteiros e flutuantes:");
            Console.WriteLine("Adição:");
            Console.WriteLine("Integral A + Integral B: " + (intA + intB));
            Console.WriteLine("Float A + Float B: " + (floatA + floatB));

            Console.WriteLine("\nSubtração:");
            Console.WriteLine("Integral A - Integral B: " + (intA - intB));
            Console.WriteLine("Float A - Float B: " + (floatA - floatB));

            Console.WriteLine("\nMultiplicação:");
            Console.WriteLine("Integral A * Integral B: " + (intA * intB));
            Console.WriteLine("Float A * Float B: " + (floatA * floatB));

            Console.WriteLine("\nDivisão:");
            Console.WriteLine("Integral A / Integral B: " + (intA / intB));
            Console.WriteLine("Float A / Float B: " + (floatA / floatB));

            Console.WriteLine("\nOperações mistas:");
            Console.WriteLine("Integral A - Float B: " + (intA - floatB));
            Console.WriteLine("Float A + Integral B: " + (floatA + intB));

            Console.WriteLine("\nOperações com tipos de diferentes precisões:");
            Console.WriteLine("Soma (float + double): " + (pontoFlutuanteFloat + pontoFlutuanteDouble));
            Console.WriteLine("Subtração (double - decimal): " + (pontoFlutuanteDouble - (double)pontoFlutuanteDecimal));
            Console.WriteLine("Multiplicação (integral * float): " + (integral * pontoFlutuanteFloat));
            Console.WriteLine("Divisão (decimal / integral): " + (pontoFlutuanteDecimal / integral));
            Console.WriteLine("Soma mista (float + double + decimal): " + (pontoFlutuanteFloat + pontoFlutuanteDouble + (double)pontoFlutuanteDecimal));

            Console.WriteLine("\nResultados armazenados em variáveis:");
            Console.WriteLine("Integral A + Integral B (int): " + intSomaIntAeIntB);
            Console.WriteLine("Integral A + Float B (int): " + intSomaIntAeFloatB);
            Console.WriteLine("Integral A + Float B (float): " + floatSomaIntAeFloatB);

            Console.WriteLine("\nDemonstração de precisão em divisões:");
            Console.WriteLine("Divisão com float (6-9 dígitos): " + (pontoFlutuanteFloat / 3));
            Console.WriteLine("Divisão com double (15-17 dígitos): " + (pontoFlutuanteDouble / 3));
            Console.WriteLine("Divisão com decimal (28-29 dígitos): " + (pontoFlutuanteDecimal / 3));
        }
    }
}