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
            Console.WriteLine(somar(45, 90));
            Console.Write("Insira o ano do seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.Write("Você faz parte da " + descobreGeracao(anoNascimento));

        }

        static void exibirTexto() // Função que não retorna nenhum valor
        {
            Console.WriteLine("Exibindo texto por meio da funcao exibirTexto()");
        }

        // Se for definido um tipo pra retornar o valor o return se torna obrigatório
        static int somar(int num1, int num2) // Função que retorna um valor int
        {
            int resultado = num1 + num2;
            return resultado;
        }
        static string descobreGeracao(int anoNascimento) // Função que retorna um valor string
        {

            if (anoNascimento >= 2010)
            {
                return "Geração Alpha";
            }
            else if (anoNascimento < 2010 && anoNascimento >= 1997)
            {
                return "Geração Z";
            }
            else if (anoNascimento < 1997 && anoNascimento >= 1981)
            {
                return "Geração Y, também conhecidos como Millennials";
            }
            else if (anoNascimento < 1981 && anoNascimento >= 1965)
            {
                return "Geração X";
            }
            else if (anoNascimento < 1965 && anoNascimento >= 1945)
            {
                return "Geração Baby Boomers";
            }
            else
            {
                return "Geração que precede os Baby Boomers";
            }
        }

       
    }
}
