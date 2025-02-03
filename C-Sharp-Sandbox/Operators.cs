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
            // Declaração das variáveis para utilização dos operadores
            int intA = 56;
            int intB = 12;
            float floatA = 155.1f;
            float floatB = 4.1542f;
            double doubleA = 34.2425364326234;
            decimal decimalA = 13.99m;

            // Variáveis para armazenar resultados
            int intSomaIntAeIntB = intA + intB;
            int intSomaFloatAeIntB = (int)(floatA + intB); //'(int)' converte para int o valor entre parenteses a direita
            int intSomaIntAeFloatB = (int)(intA + floatB);
            float floatSomaIntAeFloatB = intA + floatB;

            Console.WriteLine("Valores das variáveis:");
            Console.WriteLine("Integral A: " + intA);
            Console.WriteLine("Integral B: " + intB);
            Console.WriteLine("Flutuante (double) A: " + floatA);
            Console.WriteLine("Flutuante (double) B: " + floatB);
            Console.WriteLine("Flutuante (double) A: " + doubleA);
            Console.WriteLine("Flutuante (decimal) A: " + decimalA);

            Console.WriteLine("Operadores Aritméticos:");

            Console.WriteLine("\nOperações básicas entre inteiros e flutuantes:");
            Console.WriteLine("Adição:");
            Console.WriteLine("Integral A + Integral B: " + (intA + intB));
            Console.WriteLine("Float A + Float B: " + (floatA + floatB));
            Console.WriteLine("Integral A + Float B: " + (intA + floatB));

            Console.WriteLine("\nSubtração:");
            Console.WriteLine("Integral A - Integral B: " + (intA - intB));
            Console.WriteLine("Float A - Float B: " + (floatA - floatB));
            Console.WriteLine("Integral A - Float B: " + (intA - floatB));

            Console.WriteLine("\nMultiplicação:");
            Console.WriteLine("Integral A * Integral B: " + (intA * intB));
            Console.WriteLine("Float A * Float B: " + (floatA * floatB));
            Console.WriteLine("Integral A * Float B: " + (intA * floatB));

            Console.WriteLine("\nDivisão:");
            Console.WriteLine("Integral A / Integral B: " + (intA / intB));
            Console.WriteLine("Float A / Float B: " + (floatA / floatB));
            Console.WriteLine("Integral A / Float B: " + (intA / floatB));

            Console.WriteLine("\nOperações mistas:");
            Console.WriteLine("Integral A - Float B: " + (intA - floatB));
            Console.WriteLine("Float A + Integral B: " + (floatA + intB));
            Console.WriteLine("Integral A + Float B: " + (intA + floatB));

            Console.WriteLine("\nOperações com tipos de diferentes precisões:");
            Console.WriteLine("Soma (float + double): " + (floatA + doubleA));
            Console.WriteLine("Subtração (double - decimal): " + (doubleA - (double)decimalA));
            Console.WriteLine("Multiplicação (integral * float): " + (intA * floatA));
            Console.WriteLine("Divisão (decimal / integral): " + (decimalA / intA));
            Console.WriteLine("Soma mista (float + double + decimal): " + (floatA + doubleA + (double)decimalA));

            Console.WriteLine("\nResultados armazenados em variáveis:");
            Console.WriteLine("Integral A + Integral B (int): " + intSomaIntAeIntB);
            Console.WriteLine("Integral A + Float B (int): " + intSomaIntAeFloatB);
            Console.WriteLine("Integral A + Float B (float): " + floatSomaIntAeFloatB);

            Console.WriteLine("\nDemonstração de precisão em divisões:");
            Console.WriteLine("Divisão com float (6-9 dígitos): " + (floatA / 3));
            Console.WriteLine("Divisão com double (15-17 dígitos): " + (doubleA / 3));
            Console.WriteLine("Divisão com decimal (28-29 dígitos): " + (decimalA / 3));

            // ------------------------------

            Console.WriteLine("\n\nCondicionais:");

            // if, else if, else
            if (intA == intB)
            {
                Console.WriteLine("Os integrais são iguais");
            }
            else if (intA > floatB)
            {
                Console.WriteLine("Integral A é menor ou igual ao Flutuante (float) A");
            }
            else
            { 
              Console.WriteLine("Os integrais não são iguais e o int A é menor que float B");
            }

            // ------------------------------

            Console.WriteLine("Exemplo com operadores lógicos:");
            Console.Write("Insira o ano de seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            if (anoNascimento >= 2010)
            {
                Console.WriteLine("Geração Alpha");
            }
            else if (anoNascimento < 2010 && anoNascimento >= 1997)
            {
                Console.WriteLine("Geração Z");
            }
            else if (anoNascimento < 1997 && anoNascimento >= 1981)
            {
                Console.WriteLine("Geração Y, também conhecidos como Millennials");
            }
            else if (anoNascimento < 1981 && anoNascimento >= 1965)
            {
                Console.WriteLine("Geração X");
            }
            else if (anoNascimento < 1965 && anoNascimento >= 1945)
            {
                Console.WriteLine("Geração Baby Boomers");
            }
            else
            {
                Console.WriteLine("Seu nascimento ocorreu antes da geração Baby Boomers");
            }
        }
    }
}