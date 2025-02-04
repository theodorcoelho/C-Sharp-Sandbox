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
            int index = 0;
            while (index < 8) // enquanto a condição for verdadeira, o loop será executado
            {
                Console.WriteLine("Estrutura de repetição while!");
                index++;
                
            }
            Console.WriteLine("\nWhile Loop executado " + index + " vezes.");
        }
    }
}
