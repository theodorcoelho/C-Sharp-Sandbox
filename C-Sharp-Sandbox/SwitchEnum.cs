using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Sandbox
{
    internal class SwitchEnum
    {
        static void Main(string[] args)
        {
            string corEscolhida = "Azul";

            switch(corEscolhida)
            {
                case "Vermelho":
                    Console.WriteLine("Você escolheu vermelho");
                    break;
                case "Azul":
                    Console.WriteLine("Você escolheu azul");
                    break;
                case "Roxo":
                    Console.WriteLine("Você escolheu roxo");
                    break;
                case "Verde":
                    Console.WriteLine("Você escolheu verde");
                    break;
                default: // opção padrão que será executada se não entrar em nenhum case
                    Console.WriteLine("Ainda não trabalhamos com esta cor.");
                    break;
            }
        }
    }
}
