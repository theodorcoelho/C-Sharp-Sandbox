using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C_Sharp_Sandbox
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            exibirTexto();
            Console.Write("Insira o ano do seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            descobreGeracao(anoNascimento);
        }

        static void exibirTexto()
        {
            Console.WriteLine("Exibindo texto por meio da funcao exibirTexto()");
        }

        static void descobreGeracao(int anoNascimento)
        {
            Console.Write("Você faz parte da ");

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
                Console.WriteLine("Geração que precede os Baby Boomers");
            }
        }
    }
}
