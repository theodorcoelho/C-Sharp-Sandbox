// Módulos/pacotes que serão utilizados
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C_Sharp_Sandbox
{
    internal class Program
    {
        static void Main(string[] args) // Função principal -> Primeiro bloco de código que será executado
        {
            Console.Write("Este comando escreve o texto entre aspas no prompt de comando");

            Console.Write("\n\nAcrescentando quebra de linha\ndentro do texto\n\n");
            Console.Write("Se não quebrar linha... ");
            Console.Write("O texto será escrito um ao lado do outro.\n\n");

            Console.WriteLine("Este comando acrescenta uma quebra de linha depois do texto");
            Console.Write("Hello World!");
        }
    }
}
