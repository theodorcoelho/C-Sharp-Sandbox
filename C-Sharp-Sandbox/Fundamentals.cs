// Módulos/pacotes que serão utilizados
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C_Sharp_Sandbox
{
    internal class Fundamentals
    {
        static void Main(string[] args) // Função principal -> Primeiro bloco de código que será executado
        {
            // Exibição de Texto no Console
            Console.Write("Este comando escreve o texto entre aspas no prompt de comando");

            Console.Write("\n\nAcrescentando quebra de linha\ndentro do texto\n\n");
            Console.Write("Se não quebrar linha... ");
            Console.Write("O texto será escrito um ao lado do outro.\n\n");

            Console.WriteLine("Este comando acrescenta uma quebra de linha depois do texto");
            Console.Write("Hello World!");

            Console.WriteLine("\n");

            // Declaração de Variáveis

            // É possível criar tipos de dados personalizados
            // Principais tipos de dados que já vem definidos: 

            int integral = 12; // Integral = Números Inteiros
            float pontoFlutuanteFloat = 1.1f; // Números Reais ~6 a 9 dígitos
            double pontoFlutuanteDouble = 34.2425364326234; // Números Reais ~15 a 17 dígitos
            decimal pontoFlutuanteDecimal = 13.99m;// Números Reais  28 a 29 dígitos
            bool booliano = true; // alias classe System.Boolean = Valor booliano -> Verdadeiro ou Falso
            string cadeiaCaracteres = "Cadeia de Caracteres v1.0";// alias classe .String = Dados inseridos entre aspas duplas
            char caracter = 'A'; // Caracter ÚNICO inserido entre aspas simples

           
            Console.WriteLine("Variável Int: " + integral);
            Console.WriteLine("Variável Float: " + pontoFlutuanteFloat);
            Console.WriteLine("Variável Double: " + pontoFlutuanteDouble);
            Console.WriteLine("Variável Decimal: " + pontoFlutuanteDecimal);
            Console.WriteLine("Variável Bool: " + booliano);
            Console.WriteLine("Variável String: " + cadeiaCaracteres);
            Console.WriteLine("Variável Char: " + caracter);

            Console.WriteLine("\n~Editando valores das variáveis\n");

            integral = 98;
            pontoFlutuanteFloat = 234.134f;
            pontoFlutuanteDouble = 11.11111114;
            pontoFlutuanteDecimal = 19.99m;
            booliano = false;
            cadeiaCaracteres = "Cadeia de Caracteres v2.0";
            caracter = 'E';

            Console.WriteLine("Variável Int (editada): " + integral);
            Console.WriteLine("Variável Float (editada): " + pontoFlutuanteFloat);
            Console.WriteLine("Variável Double (editada): " + pontoFlutuanteDouble);
            Console.WriteLine("Variável Decimal (editada): " + pontoFlutuanteDecimal);
            Console.WriteLine("Variável Bool (editada): " + booliano);
            Console.WriteLine("Variável String (editada): " + cadeiaCaracteres);
            Console.WriteLine("Variável Char (editada): " + caracter);

            // Declaração de Constantes -> acrescentar a palavra reservada const antes do tipo do dado
            Console.WriteLine("\n~Declarando a constante PI\n");
            const float numeroConstantePI = 3.1415f;
            Console.WriteLine("Constante PI: " + numeroConstantePI);

            // Captura de Entrada de Dados
            Console.Write("~Recebendo dados inseridos pelo prompt: ");
            string inputUsuario = System.String.Empty; // Inicializando a variável inputUsuario vazia, seria o mesmo de usar = ""

            inputUsuario = Console.ReadLine(); // Programa lê o que foi inserido via prompt e armazena na variável
            Console.WriteLine("Valor inserido pelo usuário: " + inputUsuario);

            Console.Write("~Nova leitura: ");
            inputUsuario = Console.ReadLine();
            Console.WriteLine("Valor inserido na nova leitura: " + inputUsuario);
        }
    }
}
