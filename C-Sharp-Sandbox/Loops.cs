using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Sandbox
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            // WHILE LOOP
            int index = 0;
            while (index < 5) // enquanto a condição for verdadeira, o loop será executado
            {
                Console.WriteLine("Estrutura de repetição while!");
                index++;
                
            }
            Console.WriteLine("\nWhile Loop executado " + index + " vezes.\n");
            index = 0; // zerando o contador

            // DO WHILE LOOP

            do // programa será executado uma vez e se a condição no final for verdadeira, será executado novamente
            {
                Console.WriteLine("Estrutura de repetição do while!");
                index++;
            } while (index < 5);
            Console.Write("\n");
            // FOREACH

            string[] nomes = { "Theodor", "Pedro", "Lupin", "Lucas", "Jose"};
            Console.Write("Insira o nome que está buscando: ");
            string nomeBuscado = Console.ReadLine();

            foreach (string nome in nomes) // Para cada nome do array nomes, repita o bloco de código
            {
                Console.Write(nome);
                if (nome == nomeBuscado)
                {
                    Console.Write("  <--- Encontrei!");
                }
                Console.Write("\n");
            }
        }
    }
}
